using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using NIRS_DB;

namespace NIRS
{
    public partial class MainForm : Form
    {
        AboutBox about_box = new AboutBox();
        DataView dvTable = new DataView();
        //string connection_string = "Server=localhost;Port=3306;Database=nirs;Uid=root;Pwd=;";
        //MySql.Data.MySqlClient.MySqlConnection mySqlConnection;

        public static void SelectAllFromAndAdd(string table_name, DataGridView dataView, object tempDataTable)
        {
            DataView t = new DataView();
            string connection_string = "Server=localhost;Port=3306;Database=nirs;Uid=root;Pwd=;";
            MySql.Data.MySqlClient.MySqlConnection mc = new MySqlConnection(connection_string);
            mc.Open();
            MySqlCommand mcmd = new MySqlCommand("SELECT * FROM `" + table_name + "` ORDER BY `id`;", mc);
            ((DataTable)tempDataTable).Load(mcmd.ExecuteReader());
            t.Table = (DataTable)tempDataTable;
            dataView.DataSource = t;
            
        }


        public MainForm()
        {
            InitializeComponent();

            //DBSettings dbs = new DBSettings();
            //dbs.database = "nirs";
            //dbs.host = "localhost";
            //dbs.port = "3306";
            //dbs.pwd = "";
            //dbs.user = "root";

            //DBConnection.Connection(dbs);

            //mySqlConnection = new MySqlConnection(connection_string);

            tabControl1_SelectedIndexChanged(null, null);
        }

        private void AddRecord_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //addSomeOne addsmone = new addSomeOne();
            //addsmone.ShowDialog();
        }

        private void Exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void About_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about_box.ShowDialog();
        }

        private void факультетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SelectAllFromAndAdd("faculty", dataGridViewMain, new nirsDataSet.facultyDataTable());
        }

        private void кафедрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            //SelectAllFromAndAdd("division", dataGridViewMain, new nirsDataSet.divisionDataTable());
        }

        private void специальностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SelectAllFromAndAdd("spec", dataGridViewMain, new nirsDataSet.specDataTable());
        }

        private void группыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SelectAllFromAndAdd("group", dataGridViewMain, new nirsDataSet.groupDataTable());
        }

        private void руководителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SelectAllFromAndAdd("mentor", dataGridViewMain, new nirsDataSet.mentorDataTable());
        }

        private void студентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SelectAllFromAndAdd("student", dataGridViewMain, new nirsDataSet.studentDataTable());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nirsDataSetMain.works' table. You can move, or remove it, as needed.
            this.worksTableAdapter.Fill(this.nirsDataSetMain.works);
            // TODO: This line of code loads data into the 'nirsDataSetMain.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.nirsDataSetMain.student);
            // TODO: This line of code loads data into the 'nirsDataSetMain.mentor' table. You can move, or remove it, as needed.
            this.mentorTableAdapter.Fill(this.nirsDataSetMain.mentor);
            // TODO: This line of code loads data into the 'nirsDataSetMain.spec' table. You can move, or remove it, as needed.
            this.specTableAdapter.Fill(this.nirsDataSetMain.spec);
            // TODO: This line of code loads data into the 'nirsDataSetMain.group' table. You can move, or remove it, as needed.
            this.groupTableAdapter.Fill(this.nirsDataSetMain.group);
            // TODO: This line of code loads data into the 'nirsDataSetMain.faculty' table. You can move, or remove it, as needed.
            this.facultyTableAdapter.Fill(this.nirsDataSetMain.faculty);
            // TODO: This line of code loads data into the 'nirsDataSetMain.division' table. You can move, or remove it, as needed.
            this.divisionTableAdapter.Fill(this.nirsDataSetMain.division);
            // TODO: This line of code loads data into the 'nirsDataSetMain.division' table. You can move, or remove it, as needed.
            this.divisionTableAdapter.Fill(this.nirsDataSetMain.division);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //divisionBindingNavigator.BindingSource = facultyBindingSource;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //switch (tabControl1.SelectedTab.Text)
            //{
            //    case "Факультеты":
            //        divisionBindingNavigator.BindingSource = facultyBindingSource;
            //        break;
            //    case "Кафедры":
            //        divisionBindingNavigator.BindingSource = divisionBindingSource;
            //        break;
            //    case "Специальности":
            //        divisionBindingNavigator.BindingSource = specBindingSource;
            //        break;
            //    case "Группы":
            //        divisionBindingNavigator.BindingSource = groupBindingSource;
            //        break;
            //    case "Руководители":
            //        divisionBindingNavigator.BindingSource = mentorBindingSource;
            //        break;
            //    case "Студенты":
            //        divisionBindingNavigator.BindingSource = studentBindingSource;
            //        break;
            //    case "Научные работы":
            //        divisionBindingNavigator.BindingSource = worksBindingSource;
            //        break;
            //}
        }

        private void divisionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.divisionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nirsDataSetMain);

        }

        private void divisionBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.divisionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nirsDataSetMain);

        }

    }
}
