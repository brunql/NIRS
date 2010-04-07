using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace NIRS_Viewer
{
	/// <summary>
	/// This class saves DataSet, that we using everywhere it possible.
	/// </summary>
	public class config
	{
        //private static string _connection_string ;
        //private static MySqlConnection _connection;
		private static nirsDataSetMain nirsDataSet;
        private static NIRS_Viewer.nirsDataSetMainTableAdapters.TableAdapterManager tableAdapterManager;

        //public static string NIRS_ConnectionString
        //{
        //    get
        //    {
        //        if (_connection_string == null)
        //        { throw new Exception("property didn't initialize. Use \"Initialize\" method"); }
        //        else
        //        { return _connection_string; }
        //    }
        //    set { _connection_string = value; }
        //}

        //public static MySqlConnection NIRS_MySqlConnection {get {if(_connection==null)
        //                                                { throw new Exception("property didn't initialize. Use \"Initialize\" method"); }
        //                                            else
        //                                                {return _connection;}}
        //                                        set{ _connection = value;} }

        public static nirsDataSetMain NIRS_DataSet
        {
            get
            {
                if (nirsDataSet == null)
                { throw new Exception("property didn't initialize. Use \"Initialize\" method"); }
                else
                { return nirsDataSet; }
            }
            set { nirsDataSet = value; }
        }
		
  
		public static void Initialize(string conn)
		{
			NIRS_DataSet = new nirsDataSetMain();
            tableAdapterManager = new NIRS_Viewer.nirsDataSetMainTableAdapters.TableAdapterManager();
            tableAdapterManager.facultyTableAdapter = new NIRS_Viewer.nirsDataSetMainTableAdapters.facultyTableAdapter();
            tableAdapterManager.divisionTableAdapter = new NIRS_Viewer.nirsDataSetMainTableAdapters.divisionTableAdapter();
            tableAdapterManager.groupTableAdapter = new NIRS_Viewer.nirsDataSetMainTableAdapters.groupTableAdapter();
            tableAdapterManager.specTableAdapter = new NIRS_Viewer.nirsDataSetMainTableAdapters.specTableAdapter();
            tableAdapterManager.mentorTableAdapter = new NIRS_Viewer.nirsDataSetMainTableAdapters.mentorTableAdapter();
            tableAdapterManager.studentTableAdapter = new NIRS_Viewer.nirsDataSetMainTableAdapters.studentTableAdapter();
            tableAdapterManager.worksTableAdapter = new NIRS_Viewer.nirsDataSetMainTableAdapters.worksTableAdapter();

            tableAdapterManager.facultyTableAdapter.Fill(NIRS_DataSet.faculty);
            tableAdapterManager.divisionTableAdapter.Fill(NIRS_DataSet.division);
            tableAdapterManager.groupTableAdapter.Fill(NIRS_DataSet.group);
            tableAdapterManager.specTableAdapter.Fill(NIRS_DataSet.spec);
            tableAdapterManager.mentorTableAdapter.Fill(NIRS_DataSet.mentor);
            tableAdapterManager.studentTableAdapter.Fill(NIRS_DataSet.student);
            tableAdapterManager.worksTableAdapter.Fill(NIRS_DataSet.works);


            tableAdapterManager.facultyTableAdapter.Adapter.RowUpdated +=new MySqlRowUpdatedEventHandler(Adapter_RowUpdated);
            tableAdapterManager.divisionTableAdapter.Adapter.RowUpdated += new MySqlRowUpdatedEventHandler(Adapter_RowUpdated);
            tableAdapterManager.groupTableAdapter.Adapter.RowUpdated += new MySqlRowUpdatedEventHandler(Adapter_RowUpdated);
            tableAdapterManager.specTableAdapter.Adapter.RowUpdated += new MySqlRowUpdatedEventHandler(Adapter_RowUpdated);
            tableAdapterManager.mentorTableAdapter.Adapter.RowUpdated += new MySqlRowUpdatedEventHandler(Adapter_RowUpdated);
            tableAdapterManager.studentTableAdapter.Adapter.RowUpdated += new MySqlRowUpdatedEventHandler(Adapter_RowUpdated);
            tableAdapterManager.worksTableAdapter.Adapter.RowUpdated += new MySqlRowUpdatedEventHandler(Adapter_RowUpdated);
		}

        private static void Adapter_RowUpdated(object sender, MySql.Data.MySqlClient.MySqlRowUpdatedEventArgs e)
        {
            // Yea! I solve this fucking problem!
            if (e.StatementType == StatementType.Insert)
            {
                e.Row["id"] = e.Command.LastInsertedId;
            }
        }

        public static void Fill(string table_name)
        {
            throw new NotImplementedException();
            //switch (table_name)
            //{
            //    case ("faculty"): tableAdapterManager.facultyTableAdapter.Fill(NIRS_DataSet.faculty); break;
            //    case ("division"):  break;
            //    case ("group"):  break;
            //    case ("mentor"):break;
            //    case ("spec"):  break;
            //    case ("student"):  break;
            //    case ("works"): break;
            //}
        }

        public static void Save(string table_name)
        {
            try
            {
                switch (table_name)
                {
                    case ("faculty"): tableAdapterManager.facultyTableAdapter.Update(NIRS_DataSet); break;
                    case ("division"): tableAdapterManager.divisionTableAdapter.Update(NIRS_DataSet); break;
                    case ("group"): tableAdapterManager.groupTableAdapter.Update(NIRS_DataSet); break;
                    case ("mentor"): tableAdapterManager.mentorTableAdapter.Update(NIRS_DataSet); break;
                    case ("spec"): tableAdapterManager.specTableAdapter.Update(NIRS_DataSet); break;
                    case ("student"): tableAdapterManager.studentTableAdapter.Update(NIRS_DataSet); break;
                    case ("works"): tableAdapterManager.worksTableAdapter.Update(NIRS_DataSet); break;
                }
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Обновление данных в базе невозможно. Сообщение об ошибке: " + ex.Message);
                throw;
            }
        }
	}
}
