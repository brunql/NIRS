using System;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System.ComponentModel;
//using System.Collections.Generic;
//using System.Text;
//using System.Drawing;

//using Gios.Word;
//using NIRS_DB;
//using MySql.Data.MySqlClient;
using NIRS;
using NIRS_Viewer;
using NIRS_DB;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

using System.Data.OleDb;


using LinqToExcel;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelProvider provider = ExcelProvider.Create(@"FillMe_Rows.xls");
            InitDB();
            NIRS_Viewer.nirsDataSetMain.studentRow student = NIRS_Viewer.config.NIRS_DataSet.student.NewstudentRow();


            string pathToFillMeXlsFile = @"FillMe_Rows.xls";

            string connectionString = string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=Yes;IMEX=1;""", pathToFillMeXlsFile);
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                using (OleDbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT [N], [Анкета], [Студент] FROM [Анкета$]";//BuildSelect();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                SwitchQuestionAndUpdateStudentRow(student, reader.GetString(1), reader.GetString(2));
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                    }
                }
            }
            
            NIRS_Viewer.config.NIRS_DataSet.student.AddstudentRow(student);
            NIRS_Viewer.config.Save("student");



            //ExcelProvider provider = ExcelProvider.Create(@"FillMe_Rows.xls");
            //InitDB();
            //NIRS_Viewer.nirsDataSetMain.studentRow student = NIRS_Viewer.config.NIRS_DataSet.student.NewstudentRow();

            //foreach (NirsXLS_Rows_Strings nirs_row in (from t in provider.GetSheet<NirsXLS_Rows_Strings>() where (t != null) select t))
            //{
            //    Console.WriteLine(nirs_row.N.ToString() + ": " + nirs_row.Анкета + ": " + nirs_row.Студент);
            //    if (nirs_row.Студент != null)
            //        nirs_row.Студент = nirs_row.Студент.Replace('\'', ' ').Replace('"', ' ').Replace(';', ' ');
            //    try
            //    {
            //        SwitchQuestionAndUpdateStudentRow(student, nirs_row.Анкета, nirs_row.Студент);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}

            //Console.WriteLine("\n\nHello there!\n\n");

            //foreach (NirsXLS_Rows_Numbers nirs_row in (from t in provider.GetSheet<NirsXLS_Rows_Numbers>() where (t != null) select t))
            //{
            //    Console.WriteLine(nirs_row.N.ToString() + ": " + nirs_row.Анкета + ": " + nirs_row.Студент);
            //    try
            //    {
            //        SwitchQuestionAndUpdateStudentRow(student, nirs_row.Анкета, nirs_row.Студент);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}

            

            //    if (nirs_row.РегN == null)
            //        Console.WriteLine("reg n == null");
            //    else
            //        Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}",
            //            nirs_row.РегN,
            //            nirs_row.ФИОстудента,
            //            nirs_row.Факультет,
            //            nirs_row.Кафедра,
            //            nirs_row.Специальност_N_и_название,
            //            nirs_row.Nгруппы,
            //            nirs_row.Датарождения,
            //            nirs_row.Успев
            //            );
            //}

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

        private static void SwitchQuestionAndUpdateStudentRow(NIRS_Viewer.nirsDataSetMain.studentRow student, string question, string answer)
        {
            answer = answer.Trim();
            switch (question)
            {
                case "Фамилия":
                    if (answer != null && answer.ToString() != "") student.surname = answer.ToString();
                    else throw new ArgumentNullException("Фамилия");
                    break;
                case "Имя":
                    if (answer != null && answer.ToString() != "") student.name = answer.ToString();
                    else throw new ArgumentNullException("Имя");
                    break;
                case "Отчество":
                    if (answer != null && answer.ToString() != "") student.fathername = answer.ToString();
                    else throw new ArgumentNullException("Отчество");
                    break;
                case "Дата рождения":
                    if (answer != null && answer.ToString() != "")
                    {
                        try
                        {
                            DateTime born = Convert.ToDateTime(answer.ToString());
                            student.born = born;
                        }
                        catch
                        {
                            throw new ArgumentException("Дата рождения");
                        }
                    }
                    //else
                    //{
                    //    // Test me!
                    //    student.born = new DateTime();
                    //}
                    break;
                case "Группа":
                    //if (answer != null && answer.ToString() != "") student.group_id = FindGroupIdByName(answer.ToString());
                    //else throw new ArgumentNullException("Группа");
                    student.group_id = 93;
                    break;
                case "Успеваемость (средний балл)":
                    if (answer != null && answer.ToString() != "") student.gpa = answer.ToString();
                    break;
                case "Форма обучения":
                    if (answer != null && answer.ToString() != "") student.study = answer.ToString();
                    break;
                case "Стипендия":
                    if (answer != null && answer.ToString() != "") student.grant = answer.ToString();
                    break;
                case "Сколько лет занимается НИР":
                    try
                    {
                        if (answer != null && answer.ToString() != "") student.nir_years = Convert.ToUInt32(answer.ToString());
                        else Console.WriteLine("null");
                    }
                    catch { throw new ArgumentException("Сколько лет занимается НИР"); }
                    break;
                case "Научная тематика, по которой работает студент":
                    if (answer != null && answer.ToString() != "") student.scince_theme = answer.ToString();
                    break;
                case "ФИО научного руководителя":
                    //if (answer != null && answer.ToString() != "") student.MENTOR_ID = answer.ToString();
                    //else throw new ArgumentNullException("ФИО научного руководителя");
                    break;
                case "Место работы научного руководителя":
                    //if (answer != null && answer.ToString() != "") student.MENTOR_ID_WORK = answer.ToString();
                    //else throw new ArgumentNullException("Место работы научного руководителя");
                    break;
                case "Ученая степень научного руководителя":
                    break;
                case "Ученое звание научного руководителя":
                    break;
                case "Количество публикаций":
                    try
                    {
                        if (answer != null && answer.ToString() != "") student.publications_count = Convert.ToUInt32(answer.ToString());
                    }
                    catch { throw new ArgumentException("Количество публикаций"); }
                    break;
                case "Количество статей":
                    try
                    {
                        if (answer != null && answer.ToString() != "") student.articles_count = Convert.ToUInt32(answer.ToString());
                    }
                    catch { throw new ArgumentException("Количество статей"); }
                    break;
                case "Объекты интеллектуальной и промышленной собственности (количество)":
                    try
                    {
                        if (answer != null && answer.ToString() != "") student.intelectual_and_industryal_property_count = Convert.ToUInt32(answer.ToString());
                    }
                    catch { throw new ArgumentException("Объекты интеллектуальной и промышленной собственности (количество)"); }
                    break;
                case "Патенты и полезные модели":
                    try
                    {
                        if (answer != null && answer.ToString() != "") student.patents_count = Convert.ToUInt32(answer.ToString());
                    }
                    catch { throw new ArgumentException("Патенты и полезные модели"); }
                    break;
                case "Свидетельства на программы для ЭВМ":
                    try
                    {
                        if (answer != null && answer.ToString() != "") student.certificate_on_pc_soft_count = Convert.ToUInt32(answer.ToString());
                    }
                    catch { throw new ArgumentException("Свидетельства на программы для ЭВМ"); }
                    break;
                case "Заявки на изобретения и полезные модели":
                    try
                    {
                        if (answer != null && answer.ToString() != "") student.requests_on_inventions_and_untity_models_count = Convert.ToUInt32(answer.ToString());
                    }
                    catch { throw new ArgumentException("Заявки на изобретения и полезные модели"); }
                    break;
                case "Положительные решения на изобретения и полезные модели":
                    try
                    {
                        if (answer != null && answer.ToString() != "") student.positive_solutions_on_inventions_and_utility_models_count = Convert.ToUInt32(answer.ToString());
                    }
                    catch { throw new ArgumentException("Положительные решения на изобретения и полезные модели"); }
                    break;
                case "Программы для ЭВМ":
                    try
                    {
                        if (answer != null && answer.ToString() != "") student.requests_pc_soft_count = Convert.ToUInt32(answer.ToString());
                    }
                    catch { throw new ArgumentException("Программы для ЭВМ"); }
                    break;
                case "Внедрение в производство":
                    if (answer != null && answer.ToString() != "") student.implementation_in_industry_txt = answer.ToString();
                    break;
                case "Внедрение в учебный процесс":
                    if (answer != null && answer.ToString() != "") student.implementation_in_study_txt = answer.ToString();
                    break;
                case "Награды за научную работу":
                    if (answer != null && answer.ToString() != "") student.awards_for_scientific_work = answer.ToString();
                    break;
                case "Желает ли учиться в аспирантуре (да/нет)":
                    if (answer.ToString().Trim().ToLower() == "да")
                        student.would_u_like_to_study_in_graduate_school = true;
                    else if (answer.ToString().Trim().ToLower() == "нет" ||
                        answer.ToString().Trim().ToLower() == "")
                        student.would_u_like_to_study_in_graduate_school = false;
                    else throw new ArgumentException("Желает ли учиться в аспирантуре (да/нет)");
                    break;
                case "Желает ли работать в научно-образовательной сфере (да/нет)":
                    if (answer.ToString().Trim().ToLower() == "да")
                        student.would_u_like_to_work_in_science_education_field = true;
                    else if (answer.ToString().Trim().ToLower() == "нет" ||
                        answer.ToString().Trim().ToLower() == "")
                        student.would_u_like_to_work_in_science_education_field = false;
                    else throw new ArgumentException("Желает ли работать в научно-образовательной сфере (да/нет)");
                    break;
                case "Планирует ли кафедра оставить студента работать на кафедре (да/нет)":
                    if (answer.ToString().Trim().ToLower() == "да")
                        student.division_wants_to_leave_student_in_division = true;
                    else if (answer.ToString().Trim().ToLower() == "нет" ||
                        answer.ToString().Trim().ToLower() == "")
                        student.division_wants_to_leave_student_in_division = false;
                    else throw new ArgumentException("Планирует ли кафедра оставить студента работать на кафедре (да/нет)");
                    break;
                case "Контактные телефоны (сотовый, домашний, кафедры)":
                    if (answer != null && answer.ToString() != "") student.phone = answer.ToString();
                    break;
                case "Домашний адрес":
                    if (answer != null && answer.ToString() != "") student.address_home = answer.ToString();
                    break;
                case "Е-mail":
                    if (answer != null && answer.ToString() != "") student.email = answer.ToString();
                    break;
                case "Уровень перспективности  для НиОД (1,2,3)":
                    if (answer != null && answer.ToString() != "")
                    {
                        try
                        {
                            student.nir_level_prospects = Convert.ToUInt32(answer);
                        }
                        catch
                        {
                            throw new ArgumentException("Уровень перспективности  для НиОД (1,2,3)");
                        }
                    }
                    break;
                default:
                    throw new ArgumentException("Анкета = '" + question + "' не прописана в программе.");
                //break;
            }
        }


        private static void InitDB()
        {

            try
            {
                NIRS_Viewer.config.Initialize();
                Logs.WriteLine("InitDB: Try to connect to MySQL deamon.");
                DBConnection.ConnectionWithDefaultSettings();
                Logs.WriteLine("InitDB: Success connection to MySQL. MySQL deamon already loaded.");
            }
            catch (IOException ex_io)
            {
                Logs.WriteLine(ex_io.Message + "\n" + ex_io.Message);
                Environment.Exit(4);
            }
            catch (MySqlException ex)
            {
                Logs.WriteLine("InitDB: Fail first connection to MySQL. MySQL deamon didn't load yet. " + ex.ToString());
                    string pathToMysqld = @"C:\Program Files\xampp\mysql\bin\mysqld.exe";
                    string pathToMyCnf = @"C:\Program Files\xampp\mysql\bin\my.cnf";

                    try
                    {
                        Process MySQL_Process = new Process();
                        // C:\Program Files\xampp\mysql\bin\mysqld --defaults-file=mysql\bin\my.cnf --standalone
                        MySQL_Process.StartInfo.FileName = pathToMysqld;
                        MySQL_Process.StartInfo.Arguments = "--defaults-file=\"" + pathToMyCnf + "\" --standalone";
                        //p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Minimized;
                        // Disable console window
                        MySQL_Process.StartInfo.RedirectStandardOutput = true;
                        MySQL_Process.StartInfo.UseShellExecute = false;
                        MySQL_Process.StartInfo.CreateNoWindow = true;
                        Logs.WriteLine("MainForm_Load: Try to start MySQL process " + pathToMysqld + " with config " + pathToMyCnf);
                        MySQL_Process.Start();
                        MySQL_Process = null; // GC come here!
                        Logs.WriteLine("MainForm_Load: Try to connect to MySQL deamon.");
                        DBConnection.ConnectionWithDefaultSettings();
                    }
                    catch (Win32Exception ex_s)
                    {
                        Logs.WriteLine("InitDB: Win32Exception: " + ex_s.ToString());
                        Environment.Exit(2);
                    }
                    catch (MySqlException ex_mysql)
                    {
                        Logs.WriteLine("InitDB: MySqlException: " + ex_mysql.ToString());
                        Environment.Exit(3);
                    }
            }
            Logs.WriteLine("MainForm_Load: Initialized.");
        }
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








//            //string connection_string =
//            //    "server=localhost;port=3306;uid=nirs;pwd=;database=nirs;";
//            //MySqlConnection conn = new MySqlConnection(connection_string);
//            //conn.Open();

//            //Console.WriteLine("sucks");

////            DBConnection.ConnectionWithDefaultSettings();

////            string pathToFile = @"C:\Users\Миха\Documents\test.doc";

////            WordDocument doc = new WordDocument(WordDocumentFormat.A4_Horizontal);

////            Font timesBold = new Font("Times", 14, FontStyle.Bold);
////            Font timesRegular = new Font("Times", 14, FontStyle.Regular);
////            doc.SetTextAlign(WordTextAlign.Center);
////            doc.SetFont(timesBold);
////            MySql.Data.MySqlClient.MySqlDataReader reader = DBConnection.ExecuteReader(
////            @"SELECT COUNT(*) rows  FROM `student` s
////                        JOIN `group` g ON s.group_id = g.id
////                        JOIN `spec` spec ON g.spec_id = spec.id
////                        JOIN `mentor` m ON s.mentor_id = m.id
////                        JOIN `division` d ON spec.div_id = d.id
////                        JOIN `faculty` f ON d.fac_id = f.id;"
////            );
////            reader.Read();
////            int rows = reader.GetInt32("rows");
////            reader.Close();

////            WordTable wt = doc.NewTable(timesRegular, Color.Black, rows + 1, 6, 0);
////            foreach (WordCell rc in wt.Cells) rc.SetBorders(Color.Black, 1, true, true, true, true);
////            wt.SetContentAlignment(ContentAlignment.TopCenter);
////            reader = DBConnection.ExecuteReader(
////                    @"SELECT CONCAT(s.surname, ' ', s.name, ' ', s.fathername) `Студент`, 
////                        s.born `Дата рождения`,
////                        f.name `Факультет`,
////                        d.name `Кафедра`,
////                        spec.name `Специальность`,
////                        g.code `Группа`,
////                        CONCAT(m.name, ' ', m.fathername, ' ', m.surname) `Научный руководитель`
////                    FROM `student` s
////                        JOIN `group` g ON s.group_id = g.id
////                        JOIN `spec` spec ON g.spec_id = spec.id
////                        JOIN `mentor` m ON s.mentor_id = m.id
////                        JOIN `division` d ON spec.div_id = d.id
////                        JOIN `faculty` f ON d.fac_id = f.id;"
////                    );
////            wt.SetFont(timesBold);
////            wt.Rows[0][0].WriteControlWord(Encode("Студент (ФИО)"));
////            wt.Rows[0][1].WriteControlWord(Encode("Дата рождения"));
////            wt.Rows[0][2].WriteControlWord(Encode("Факультет"));
////            wt.Rows[0][3].WriteControlWord(Encode("Кафедра"));
////            wt.Rows[0][4].WriteControlWord(Encode("Специальность"));
////            wt.Rows[0][5].WriteControlWord(Encode("Группа"));
////            wt.Rows[0][6].WriteControlWord(Encode("Научный руководитель"));

////            wt.SetFont(timesRegular);
////            int row = 1, col = 0;
////            while (reader.Read())
////            {
////                wt.Rows[row][col++].WriteControlWord(Encode(reader.GetString("Студент")));
////                wt.Rows[row][col++].WriteControlWord(Encode(reader.GetString("Дата рождения")));
////                wt.Rows[row][col++].WriteControlWord(Encode(reader.GetString("Факультет")));
////                wt.Rows[row][col++].WriteControlWord(Encode(reader.GetString("Кафедра")));
////                wt.Rows[row][col++].WriteControlWord(Encode(reader.GetString("Специальность")));
////                wt.Rows[row][col++].WriteControlWord(Encode(reader.GetString("Группа")));
////                wt.Rows[row][col++].WriteControlWord(Encode(reader.GetString("Научный руководитель")));
////                col = 0;
////                row++;
////            }
////            reader.Close();
////            wt.SaveToDocument(13000, 0);
////            doc.SaveToFile(pathToFile);
////            System.Diagnostics.Process.Start(pathToFile);
////            Console.WriteLine("Done! " + ((int)'\\').ToString() + ((int)(@"'"[0])).ToString());
//            Console.ReadLine();
//        }


//        static string Encode(string s)
//        {
//            // TODO: try to rewrite it on StringBuilder mb this will work faster
//            string res = "";
//            foreach (char c in s.ToCharArray())
//            {
//                // \u1071u - \uN - this is unicode char num N, alternate for pure ansi have char 'u'
//                res += @"\u" + ((int)c) + "u" ;
//            }
//            return res.Remove(0,1); // first '\' added in WriteControlWord
//        }

//        //static char[] hexDigits = {
//        //                              '0', '1', '2', '3', '4', '5', '6', '7',
//        //                              '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};

//        //internal static string ToHexString(byte Byte)
//        //{
//        //    int b = Byte;
//        //    return  hexDigits[b & 0xF].ToString() + hexDigits[b >> 4].ToString();
//        //}

//        //internal static string Encode(string s)
//        //{
//        //    UnicodeEncoding ue = new UnicodeEncoding();
//        //    s = s.Replace(@"\", @"\\");
//        //    System.Text.StringBuilder sb = new System.Text.StringBuilder();
//        //    foreach (char c in s.ToCharArray())
//        //    {
//        //        if ((c >= 48 && c <= 122) || c == '\n' || c == ' ') sb.Append(c);
//        //        else
//        //        {
//        //            if (c == 'Ђ')
//        //                sb.Append(@"\'80");
//        //            else
//        //            {
//        //                string tmp = @"\u" + ((int)c);
//        //                sb.Append(tmp);
//        //            }
//        //        }
//        //    }
//        //    return sb.ToString().Replace("\r\n", @"\par").Replace("\n", @"\par ");

//        //}

//    }
//}
