using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using MySql.Data.MySqlClient;

using Gios.Word;
using NIRS_DB;

namespace NIRS
{
    public partial class MainForm : Form
    {
        private AboutBox about_box;
        public static DataTable SummaryTable { get; set; }

        public MainForm()
        {
            try
            {
                Logs.WriteLine("MainForm initializing.");
                InitializeComponent();
                about_box = new AboutBox();
            }
            catch (Exception ex)
            {
                Logs.WriteLine(ex.ToString());
            }
        }


        //public static void SelectAllFromAndAdd(string table_name, DataGridView dataView, object tempDataTable)
        //{
        //    DataTable t = new DataTable();
        //    t.Load(
        //            DBConnection.ExecuteReader("SELECT * FROM `" + table_name + "` ORDER BY `id`;")
        //        );
        //    dataView.DataSource = t;
        //}




        private void AddRecord_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AddSomeOne ads = new AddSomeOne();
                if (ads != null) ads.ShowDialog();
            }
            catch (Exception ex)
            {
                Logs.WriteLine("Exception: " + ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void Exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                Logs.WriteLine("Exception: " + ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void About_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                about_box.ShowDialog();
            }
            catch (Exception ex)
            {
                Logs.WriteLine("Exception: " + ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            try
            {
                Logs.WriteLine("MainForm_Load: Try to connect to MySQL deamon.");
                DBConnection.ConnectionWithDefaultSettings();
                Logs.WriteLine("MainForm_Load: Success connection to MySQL. MySQL deamon already loaded.");
            }
            catch (IOException ex_io)
            {
                MessageBox.Show(ex_io.Message + "\n" + ex_io.Message, "Ошибка #4");
                Environment.Exit(4);
            }
            catch (MySqlException ex)
            {
                Logs.WriteLine("MainForm_Load: Fail first connection to MySQL. MySQL deamon didn't load yet.");
                DialogResult res = MessageBox.Show("Подключение к базе не удалось, нажмите ОК для попытки запуска сервера. \n" + ex.Message, "Ошибка #1");
                if (res == DialogResult.OK)
                {
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
                        Logs.WriteLine("MainForm_Load: Win32Exception: " + ex_s.ToString());
                        MessageBox.Show("Не удается найти файл для запуска " + pathToMysqld + "\n" + ex_s.Message, "Ошибка #2");
                        Environment.Exit(2);
                    }
                    catch (MySqlException ex_mysql)
                    {
                        Logs.WriteLine("MainForm_Load: MySqlException: " + ex_mysql.ToString());
                        MessageBox.Show("Сервер не запустился, либо что-то с настройками подключения.\n" + ex_mysql.Message, "Ошибка #3");
                        Environment.Exit(3);
                    }
                }
                else
                {
                    Logs.WriteLine("MainForm_Load: Start of MySQL deamon canceled.");
                    Environment.Exit(1);
                }
            }
            LoadSummaryDataGridTable();
            this.summaryDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            Logs.WriteLine("MainForm_Load: Initialized.");
        }

        //SettingsConnectionForm scf = new SettingsConnectionForm();
        //if (scf.ShowDialog() == DialogResult.Cancel)
        //{
        //    Environment.Exit(93);
        //}


        private void LoadSummaryDataGridTable()
        {
            try
            {
                Logs.WriteLine("LoadSummaryDataGridTable() starts.");
                DataView t = new DataView();
                SummaryTable = new DataTable();
                SummaryTable.Load(
                        DBConnection.ExecuteReader(
                        @"SELECT CONCAT(s.name,' ',s.fathername, ' ', s.surname) `Студент`, s.born `Дата рождения`,
                        f.name `Факультет`,
                        d.name `Кафедра`,
                        spec.name `Специальность`,
                        g.code `Группа`,
                        s.study `Форма обучения`,
                        s.`grant`  `Стипендия`

                    FROM `student` s
                        JOIN `group` g ON s.group_id = g.id
                        JOIN `spec` spec ON g.spec_id = spec.id
                        JOIN `division` d ON spec.div_id = d.id
                        JOIN `faculty` f ON d.fac_id = f.id;"
                        )
                     );
                summaryDataGridView.DataSource = SummaryTable;
                Logs.WriteLine("LoadSummaryDataGridTable() done.");
            }
            catch (Exception ex)
            {
                Logs.WriteLine("Exception: " + ex.ToString());
                MessageBox.Show("Ошибка при загрузке информации в сводную таблицу.\n" + ex.Message, "Ошибка #5");
            }
        }

        private void connectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SettingsConnectionForm scf = new SettingsConnectionForm();
                scf.ShowDialog();
            }
            catch (Exception ex)
            {
                Logs.WriteLine("Exception: " + ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void exportToWordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                SettingsWordExportForm swef = new SettingsWordExportForm();
                SettingsWordExportForm.ShowMe = SummaryTable;
                swef.ShowDialog();
            }
            catch (Exception ex)
            {
                Logs.WriteLine("Exception: " + ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void студентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FindStudentDialogForm fsdf = new FindStudentDialogForm();
                fsdf.ShowDialog();
                if (FindStudentDialogForm.Result != null)
                {
                    this.summaryDataGridView.DataSource = null;
                    this.summaryDataGridView.DataSource = FindStudentDialogForm.Result;
                    SummaryTable = FindStudentDialogForm.Result;
                }
            }
            catch (Exception ex)
            {
                Logs.WriteLine("Exception: " + ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void руководительToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FindMentorDialogForm fmdf = new FindMentorDialogForm();
                fmdf.ShowDialog();
                if (FindMentorDialogForm.Result != null)
                {
                    this.summaryDataGridView.DataSource = null;
                    this.summaryDataGridView.DataSource = FindMentorDialogForm.Result;
                    SummaryTable = FindMentorDialogForm.Result;
                }
            }
            catch (Exception ex)
            {
                Logs.WriteLine("Exception: " + ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }
        
        private void нуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FindScienceWorksDialogForm fsdf = new FindScienceWorksDialogForm();
                fsdf.ShowDialog();
                if (FindScienceWorksDialogForm.Result != null)
                {
                    this.summaryDataGridView.DataSource = null;
                    this.summaryDataGridView.DataSource = FindScienceWorksDialogForm.Result;
                    SummaryTable = FindScienceWorksDialogForm.Result;
                }
            }
            catch (Exception ex)
            {
                Logs.WriteLine("Exception: " + ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }


        private void факультетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                (new EditFaculty()).Show();
            }
            catch (Exception ex)
            {
                Logs.WriteLine("Exception: " + ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void кафедрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                (new EditDivision()).Show();
            }
            catch (Exception ex)
            {
                Logs.WriteLine("Exception: " + ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void группыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                (new EditGroup()).Show();
            }
            catch (Exception ex)
            {
                Logs.WriteLine("Exception: " + ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void специальностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                (new EditSpec()).Show();
            }
            catch (Exception ex)
            {
                Logs.WriteLine("Exception: " + ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void руководителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                (new EditMentor()).Show();
            }
            catch (Exception ex)
            {
                Logs.WriteLine("Exception: " + ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void студентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                (new EditStudent()).Show();
            }
            catch (Exception ex)
            {
                Logs.WriteLine("Exception: " + ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void научныеРаботыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                (new EditWorks()).Show();
            }
            catch (Exception ex)
            {
                Logs.WriteLine("Exception: " + ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void summaryDataGridView_DataSourceChanged(object sender, EventArgs e)
        {
            try
            {
                summaryDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                Logs.WriteLine("Exception: " + ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Start mysqld on first run of this program, and doesn't close it after use for future usings.

            //if (MySQL_Process != null)
            //{
            //    MySQL_Process.Close();
            //}
            //if(DBConnection.IsConnectionOpen()){
            //    // Stop mysqld
            //    MySQL_Process = new System.Diagnostics.Process();
            //    MySQL_Process.StartInfo.FileName = Environment.CurrentDirectory + @"\mysql_stop.bat";
            //    //p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Minimized;
            //    // Disable console window
            //    MySQL_Process.StartInfo.RedirectStandardOutput = true;
            //    MySQL_Process.StartInfo.UseShellExecute = false;
            //    MySQL_Process.StartInfo.CreateNoWindow = true;

            //    MySQL_Process.Start();
            //    MySQL_Process.WaitForExit();
            //}
        }

        private void добавлениеСтудентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AddStudent addst = new AddStudent();
                addst.ShowDialog();
            }
            catch(Exception ex)
            {
                Logs.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }


    }
}
