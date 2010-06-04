using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Reflection;
using LinqToExcel;

namespace LinqToExcel
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelProvider provider = ExcelProvider.Create(@"BaseNIRS.xls");

            foreach (NirsXLS nirs_row in (from t in provider.GetSheet<NirsXLS>() where (t.РегN != null) select t))
            {
                if (nirs_row.РегN == null)
                    Console.WriteLine("reg n == null");
                else
                    Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}",
                        nirs_row.РегN.ToString(),
                        nirs_row.ФИОстудента,
                        nirs_row.Факультет,
                        nirs_row.Кафедра,
                        nirs_row.Специальност_N_и_название,
                        nirs_row.Nгруппы,
                        nirs_row.Датарождения,//.ToShortDateString(),
                        nirs_row.Успев
                        );
            }

            //foreach (TestXLS test in (from t in provider.GetSheet<TestXLS>() where t.testA1 == "1" select t))
            //{
            //    test.testB1 = "TEST";
            //    Console.WriteLine("{0} {1} {2} {3}", test.testA1, test.testB1, test.testC1, test.testD1);
            //}
            //TestXLS t1 = new TestXLS();
            //t1.testA1 = "sadf54";
            //t1.testB1 = "I am mudilo!";
            //provider.GetSheet<TestXLS>().InsertOnSubmit(t1);
            //t1.testC1 = "asdfasdf5";
            //t1.testD1 = "asdfasd7asdfasdf";
            //provider.SubmitChanges();

            
            //foreach (Person per in (from p in provider.GetSheet<Person>() where p.LastName == "Johnson" select p))
            //{
            //    per.LastName = "Smith";
            //}
            //Person p2 = new Person();
            //p2.Id = 10.0;
            //p2.FirstName = "Alex";
            //p2.LastName = "Zander";
            //p2.BirthDate = new DateTime(1980, 4, 4);
            //provider.GetSheet<Person>().InsertOnSubmit(p2);
            //provider.SubmitChanges();
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
    //[ExcelSheet(Name = "Sheet1")]
    //public class Person : System.ComponentModel.INotifyPropertyChanged
    //{
    //    private double id;
    //    private string fName;
    //    private string lName;
    //    private DateTime bDate;
    //    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
    //    public Person()
    //    {
    //        id = 0;
    //    }
    //    protected virtual void SendPropertyChanged(string propertyName)
    //    {
    //        System.ComponentModel.PropertyChangedEventHandler handler = PropertyChanged;
    //        if (handler != null)
    //        {
    //            handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
    //        }
    //    }
    //    [ExcelColumn(Name = "ID", Storage = "id")]
    //    public double Id
    //    {
    //        get { return id; }
    //        set { id = value; }
    //    }
    //    [ExcelColumn(Name = "First Name", Storage = "fName")]
    //    public string FirstName
    //    {
    //        get { return this.fName; }
    //        set
    //        {
    //            fName = value;
    //            SendPropertyChanged("FirstName");
    //        }
    //    }
    //    [ExcelColumn(Name = "Last Name", Storage = "lName")]
    //    public string LastName
    //    {
    //        get { return this.lName; }
    //        set
    //        {
    //            lName = value;
    //            SendPropertyChanged("LastName");
    //        }
    //    }
    //    [ExcelColumn(Name = "BirthDate", Storage = "bDate")]
    //    public DateTime BirthDate
    //    {
    //        get { return this.bDate; }
    //        set
    //        {
    //            bDate = value;
    //            SendPropertyChanged("BirthDate");
    //        }
    //    }
    //}
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class ExcelColumnAttribute : Attribute
    {
        private string name;
        private string storage;
        private PropertyInfo propInfo;
        public ExcelColumnAttribute()
        {
            name = string.Empty;
            storage = string.Empty;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Storage
        {
            get { return storage; }
            set { storage = value; }
        }
        internal PropertyInfo GetProperty()
        {
            return propInfo;
        }
        internal void SetProperty(PropertyInfo propInfo)
        {
            this.propInfo = propInfo;
        }
        internal string GetSelectColumn()
        {
            if (Name == string.Empty)
            {
                return propInfo.Name;
            }
            return Name;
        }
        internal string GetStorageName()
        {
            if (Storage == string.Empty)
            {
                return propInfo.Name;
            }
            return storage;
        }
        internal bool IsFieldStorage()
        {
            return string.IsNullOrEmpty(storage) == false;
        }
    }
    public class ExcelSheetAttribute : Attribute
    {
        private string name;
        public ExcelSheetAttribute()
        {
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
    public class ExcelMapReader
    {
        public static string GetSheetName(Type t)
        {
            object[] attr = t.GetCustomAttributes(typeof(ExcelSheetAttribute), true);
            if (attr.Length == 0)
            {
                throw new InvalidOperationException("ExcelSheetAttribute not found on type " + t.FullName);
            }
            ExcelSheetAttribute sheet = (ExcelSheetAttribute)attr[0];
            if (sheet.Name == string.Empty)
                return t.Name;
            return sheet.Name;
        }
        public static List<ExcelColumnAttribute> GetColumnList(Type t)
        {
            List<ExcelColumnAttribute> lst = new List<ExcelColumnAttribute>();
            foreach (PropertyInfo propInfo in t.GetProperties())
            {
                object[] attr = propInfo.GetCustomAttributes(typeof(ExcelColumnAttribute), true);
                if (attr.Length > 0)
                {
                    ExcelColumnAttribute col = (ExcelColumnAttribute)attr[0];
                    col.SetProperty(propInfo);
                    lst.Add(col);
                }
            }
            return lst;
        }
    }
    public class ExcelConnectionString
    {
        internal static string GetConnectionString(string pFilePath)
        {
            string strConnectionString = string.Empty;
            string strExcelExt = System.IO.Path.GetExtension(pFilePath);

            if (strExcelExt == ".xls")
                strConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties= ""Excel 8.0;HDR=YES;""";
            //Ahad L. Amdani added support for .xslm for workbooks using macros
            else if (strExcelExt == ".xlsx" || strExcelExt == ".xlsm")
                strConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 12.0 Xml;HDR=YES""";
            else
                throw new ArgumentOutOfRangeException("Excel file extenstion is not known.");

            return string.Format(strConnectionString, pFilePath);

        }
    }

    public class ExcelSheet<T> : IEnumerable<T>
    {
        private ExcelProvider provider;
        private List<T> rows;
        internal ExcelSheet(ExcelProvider provider)
        {
            this.provider = provider;
            rows = new List<T>();
        }
        private string BuildSelect()
        {
            string sheet = ExcelMapReader.GetSheetName(typeof(T));
            StringBuilder builder = new StringBuilder();
            foreach (ExcelColumnAttribute col in ExcelMapReader.GetColumnList(typeof(T)))
            {
                if (builder.Length > 0)
                {
                    builder.Append(", ");
                }
                builder.AppendFormat("[{0}]", col.GetSelectColumn());
            }
            builder.Append(" FROM [");
            builder.Append(sheet);
            builder.Append("$]");
            return "SELECT " + builder.ToString();
        }
        private T CreateInstance()
        {
            return Activator.CreateInstance<T>();
        }
        private void Load()
        {
            string connectionString = ExcelConnectionString.GetConnectionString(provider.Filepath);
            List<ExcelColumnAttribute> columns = ExcelMapReader.GetColumnList(typeof(T));
            rows.Clear();
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                using (OleDbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = BuildSelect();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            T item = CreateInstance();
                            List<PropertyManager> pm = new List<PropertyManager>();
                            foreach (ExcelColumnAttribute col in columns)
                            {
                                object val = reader[col.GetSelectColumn()];
                                if (val is DBNull)
                                {
                                    val = null;
                                }
                                if (col.IsFieldStorage())
                                {
                                    FieldInfo fi = typeof(T).GetField(col.GetStorageName(), BindingFlags.GetField | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetField);
                                    //TomKom 3/13/2009 add change type conversion.
                                    fi.SetValue(item, Convert.ChangeType(val, fi.FieldType));
                                }
                                else
                                {
                                    //TomKom 3/13/2009 add change type conversion.
                                    typeof(T).GetProperty(col.GetStorageName()).SetValue(item, Convert.ChangeType(val,typeof(T).GetProperty(col.GetStorageName()).PropertyType), null);
                                }
                                pm.Add(new PropertyManager(col.GetProperty().Name, val));
                            }
                            rows.Add(item);
                            AddToTracking(item, pm);
                        }
                    }
                }
            }
        }
        private void AddToTracking(Object obj, List<PropertyManager> props)
        {
            provider.ChangeSet.AddObject(new ObjectState(obj, props));
        }
        public void InsertOnSubmit(T entity)
        {
            //Add to tracking
            provider.ChangeSet.InsertObject(entity);
        }
        public void DeleteOnSubmit(T entity)
        {
            provider.ChangeSet.DeleteObject(entity);
        }
        public IEnumerator<T> GetEnumerator()
        {
            Load();
            return rows.GetEnumerator();
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            Load();
            return rows.GetEnumerator();
        }
    }
    public class ExcelProvider
    {
        private string filePath;
        private ChangeSet changes;
        public ExcelProvider()
        {
            changes = new ChangeSet();
        }
        internal ChangeSet ChangeSet
        {
            get { return changes; }
        }
        internal string Filepath
        {
            get { return filePath; }
        }
        public static ExcelProvider Create(string filePath)
        {
            ExcelProvider provider = new ExcelProvider();
            provider.filePath = filePath;
            return provider;
        }
        public ExcelSheet<T> GetSheet<T>()
        {
            return new ExcelSheet<T>(this);
        }
        public void SubmitChanges()
        {
            string connectionString = ExcelConnectionString.GetConnectionString(this.Filepath);
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                foreach (ObjectState os in this.ChangeSet.ChangedObjects)
                {
                    using (OleDbCommand cmd = conn.CreateCommand())
                    {
                        if (os.ChangeState == ChangeState.Deleted)
                        {
                            BuildDeleteClause(cmd, os);
                        }
                        if (os.ChangeState == ChangeState.Updated)
                        {
                            BuildUpdateClause(cmd, os);
                        }
                        if (os.ChangeState == ChangeState.Inserted)
                        {
                            BuildInsertClause(cmd, os);
                        }
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
        public void BuildInsertClause(OleDbCommand cmd, ObjectState objState)
        {
            string sheet = ExcelMapReader.GetSheetName(objState.Entity.GetType());
            StringBuilder builder = new StringBuilder();
            builder.Append("INSERT INTO [");
            builder.Append(sheet);
            builder.Append("$]");
            StringBuilder columns = new StringBuilder();
            StringBuilder values = new StringBuilder();
            foreach (ExcelColumnAttribute col in ExcelMapReader.GetColumnList(objState.Entity.GetType()))
            {
                if (columns.Length > 0)
                {
                    columns.Append(", ");
                    values.Append(", ");
                }
                columns.AppendFormat("[{0}]", col.GetSelectColumn());
                string paraNum = "@x" + cmd.Parameters.Count.ToString();
                values.Append(paraNum);
                object val = col.GetProperty().GetValue(objState.Entity, null);
                OleDbParameter para = new OleDbParameter(paraNum, val);
                cmd.Parameters.Add(para);
            }
            cmd.CommandText = builder.ToString() + "(" + columns.ToString() + ") VALUES (" +
            values.ToString() + ")";
        }
        public void BuildUpdateClause(OleDbCommand cmd, ObjectState objState)
        {
            StringBuilder builder = new StringBuilder();
            string sheet = ExcelMapReader.GetSheetName(objState.Entity.GetType());
            builder.Append("UPDATE [");
            builder.Append(sheet);
            builder.Append("$] SET ");
            StringBuilder changeBuilder = new StringBuilder();
            List<ExcelColumnAttribute> cols = ExcelMapReader.GetColumnList(objState.Entity.GetType());
            List<ExcelColumnAttribute> changedCols =
            (from c in cols
             join p in objState.ChangedProperties on c.GetProperty().Name equals p.PropertyName
             where p.HasChanged == true
             select c).ToList();
            foreach (ExcelColumnAttribute col in changedCols)
            {
                if (changeBuilder.Length > 0)
                {
                    changeBuilder.Append(", ");
                }
                string paraNum = "@x" + cmd.Parameters.Count.ToString();
                changeBuilder.AppendFormat("[{0}]", col.GetSelectColumn());
                changeBuilder.Append(" = ");
                changeBuilder.Append(paraNum);
                object val = col.GetProperty().GetValue(objState.Entity, null);
                OleDbParameter para = new OleDbParameter(paraNum, val);
                cmd.Parameters.Add(para);
            }
            builder.Append(changeBuilder.ToString());
            cmd.CommandText = builder.ToString();
            BuildWhereClause(cmd, objState);
        }
        public void BuildDeleteClause(OleDbCommand cmd, ObjectState objState)
        {
            StringBuilder builder = new StringBuilder();
            string sheet = ExcelMapReader.GetSheetName(objState.Entity.GetType());
            builder.Append("DELETE FROM [");
            builder.Append(sheet);
            builder.Append("$]");
            cmd.CommandText = builder.ToString();
            BuildWhereClause(cmd, objState);
        }
        public void BuildWhereClause(OleDbCommand cmd, ObjectState objState)
        {
            StringBuilder builder = new StringBuilder();
            List<ExcelColumnAttribute> cols = ExcelMapReader.GetColumnList(objState.Entity.GetType());
            foreach (ExcelColumnAttribute col in cols)
            {

                PropertyManager pm = objState.GetProperty(col.GetProperty().Name);
                if (builder.Length > 0)
                {
                    builder.Append(" and ");
                }

                builder.AppendFormat("[{0}]", col.GetSelectColumn());
                //fix from Andrew 4/2/08 to handle empty cells
                if (pm.OrginalValue == System.DBNull.Value)
                    builder.Append(" IS NULL");
                else
                {
                    builder.Append(" = ");
                    string paraNum = "@x" + cmd.Parameters.Count.ToString();
                    builder.Append(paraNum);
                    OleDbParameter para = new OleDbParameter(paraNum, pm.OrginalValue);
                    cmd.Parameters.Add(para);
                }
            }
            cmd.CommandText = cmd.CommandText + " WHERE " + builder.ToString();
        }
    }
    public class PropertyManager
    {
        private string propertyName;
        private object orginalValue;
        private bool hasChanged;
        public PropertyManager(string propName, object value)
        {
            propertyName = propName;
            orginalValue = value;
            hasChanged = false;
        }
        public string PropertyName
        {
            get { return propertyName; }
            set { propertyName = value; }
        }
        public object OrginalValue
        {
            get { return orginalValue; }
            set { orginalValue = value; }
        }
        public bool HasChanged
        {
            get { return hasChanged; }
            set { hasChanged = value; }
        }
    }
    public enum ChangeState
    {
        Retrieved,
        Updated,
        Inserted,
        Deleted
    }
    public class ObjectState
    {
        private List<PropertyManager> propList;
        private object entity;
        private ChangeState state;
        public ObjectState(object entity, List<PropertyManager> props)
        {
            this.entity = entity;
            this.propList = props;
            state = ChangeState.Retrieved;
            if (entity is System.ComponentModel.INotifyPropertyChanged)
            {
                System.ComponentModel.INotifyPropertyChanged i = (System.ComponentModel.INotifyPropertyChanged)entity;
                i.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(i_PropertyChanged);
            }
        }
        public List<PropertyManager> Properties
        {
            get { return this.propList; }
        }
        public PropertyManager GetProperty(string propertyName)
        {
            return (from p in propList where p.PropertyName == propertyName select p).FirstOrDefault();
        }
        public List<PropertyManager> ChangedProperties
        {
            get { return (from p in propList where p.HasChanged == true select p).ToList(); }
        }
        public ChangeState ChangeState
        {
            get { return state; }
            set { state = value; }
        }
        public Object Entity
        {
            get { return this.entity; }
        }
        public void i_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            PropertyManager pm = (from p in propList where p.HasChanged == false && p.PropertyName == e.PropertyName select p).FirstOrDefault();
            if (pm != null)
            {
                pm.HasChanged = true;
                if (state == ChangeState.Retrieved)
                    state = ChangeState.Updated;
            }
        }
    }
    public class ChangeSet
    {
        private List<ObjectState> trackedList;
        public ChangeSet()
        {
            trackedList = new List<ObjectState>();
        }
        public void AddObject(ObjectState objectState)
        {
            trackedList.Add(objectState);
        }
        public void InsertObject(Object obj)
        {
            foreach (ObjectState os in trackedList)
            {
                if (ObjectState.ReferenceEquals(os.Entity, obj))
                {
                    throw new InvalidOperationException("Object already in list");
                }
            }
            ObjectState osNew = new ObjectState(obj, new List<PropertyManager>());
            osNew.ChangeState = ChangeState.Inserted;
            trackedList.Add(osNew);
        }
        public void DeleteObject(Object obj)
        {
            ObjectState os = (from o in trackedList where Object.ReferenceEquals(o.Entity, obj) == true select o).FirstOrDefault();
            if (os != null)
            {
                if (os.ChangeState == ChangeState.Inserted)
                {
                    trackedList.Remove(os);
                }
                else
                {
                    os.ChangeState = ChangeState.Deleted;
                }
            }
        }
        public List<ObjectState> ChangedObjects
        {
            get { return (from c in trackedList where c.ChangeState != ChangeState.Retrieved select c).ToList(); }
        }
    }
}





