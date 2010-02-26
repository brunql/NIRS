using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using Gios.Word;
using NIRS_DB;

namespace NIRS
{
    public partial class MainForm : Form
    {
        AboutBox about_box = new AboutBox();
        DataView dvTable = new DataView();
        string connection_string = "Server=localhost;Port=3306;Database=nirs;Uid=root;Pwd=;";
        MySql.Data.MySqlClient.MySqlConnection mySqlConnection;

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
            

            DBSettings dbs = new DBSettings();
            dbs.database = "nirs";
            dbs.host = "localhost";
            dbs.port = "3306";
            dbs.pwd = "";
            dbs.user = "root";

            DBConnection.Connection(dbs);

            mySqlConnection = new MySqlConnection(connection_string);

            tabControl1_SelectedIndexChanged(null, null);
        }

        private void AddRecord_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addSomeOne addsmone = new addSomeOne();
            addsmone.ShowDialog();
            UpdateAllDataGridView();
        }

        private void Exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void About_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about_box.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateAllDataGridView();
        }

        private void UpdateAllDataGridView()
        {
            try
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
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //divisionBindingNavigator.BindingSource = facultyBindingSource;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Text)
            {
                case "Факультеты":
                    divisionBindingNavigator.BindingSource = facultyBindingSource;
                    break;
                case "Кафедры":
                    divisionBindingNavigator.BindingSource = divisionBindingSource;
                    break;
                case "Специальности":
                    divisionBindingNavigator.BindingSource = specBindingSource;
                    break;
                case "Группы":
                    divisionBindingNavigator.BindingSource = groupBindingSource;
                    break;
                case "Руководители":
                    divisionBindingNavigator.BindingSource = mentorBindingSource;
                    break;
                case "Студенты":
                    divisionBindingNavigator.BindingSource = studentBindingSource;
                    break;
                case "Научные работы":
                    divisionBindingNavigator.BindingSource = worksBindingSource;
                    break;
            }
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

        private void exportToWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Gios.Word.WordDocument rd = new WordDocument(WordDocumentFormat.A4);

                Font bold = new Font("Helvetica", 12, FontStyle.Bold);
                Font regular = new Font("Helvetica", 12, FontStyle.Regular);
                rd.SetFont(bold);
                rd.SetTextAlign(WordTextAlign.Left);
                WordTable rt = rd.NewTable(regular, Color.Black, 7, 4, 0);
                rt.SetColumnsWidth(new int[] { 50, 9, 40, 1 });
                //foreach (WordCell rc in rt.Cells) rc.SetBorders(Color.Black,1,true,true,true,true);

                rt.SetContentAlignment(ContentAlignment.TopCenter);
                rt.Rows[0].SetRowHeight(300);
                rt.Rows[1].SetRowHeight(1400);
                rt.Rows[0][0].RowSpan = 3;
                //rt.Rows[0][0].SetContentAlignment(ContentAlignment.MiddleCenter);
                //rt.Rows[0][0].PutImage(@"..\..\cp.jpg", 70);
                rt.Rows[1][2].SetCellPadding(100);
                rt.Rows[1][2].SetContentAlignment(ContentAlignment.MiddleLeft);
                rt.Rows[1][2].SetFont(new Font("Helvetica", 9, FontStyle.Bold));
                rt.Rows[1][2].WriteLine("NIRS Project");
                rt.Rows[1][2].WriteLine("KubSTU Developers Team");
                rt.Rows[1][2].SetBorders(Color.Black, 1, true, true, true, true);
                
                rt.Rows[4][0].SetFont(bold);
                rt.Rows[4][0].ColSpan = 4;
                rt.Rows[4][0].WriteLine();
                rt.Rows[4][0].WriteLine("This is test word document\n\n");

                WordCell body = rt.Rows[6][0];
                body.ColSpan = 4;
                body.SetFont(bold);
                body.WriteLine("Word .NET:");
                body.WriteLine();
                body.SetFont(regular);
                body.WriteLine("A complete library in c# for generating Word Documents using the Rich Text Format Specification!");
                body.WriteLine();
                body.WriteLine();
                body.SetFont(bold);
                body.Write("Add here results.\n");
                body.SetFont(regular);
                body.WriteLine("Here will be table with students...\n");

                rt.SaveToDocument(10000, 0);
                rd.SetPageNumbering(155);

                rd.FooterStart();
                rd.SetTextAlign(WordTextAlign.Center);
                rd.SetFont(new Font("Verdana", 8, FontStyle.Regular));
                rd.Write("Copyright © 2010 by NIRS Project, KubSTU Dev Team");
                rd.FooterEnd();


                rd.SaveToFile(sfd.FileName);
                System.Diagnostics.Process.Start(sfd.FileName);
            }
        }
    }
}
