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
//using NIRS_database;

namespace NIRS
{
    public partial class MainForm : Form
    {
        AboutBox about_box = new AboutBox();

        public static DataTable SummaryTable { get; set; }


        public static void SelectAllFromAndAdd(string table_name, DataGridView dataView, object tempDataTable)
        {
            DataTable t = new DataTable();
            t.Load(
                    DBConnection.ExecuteReader("SELECT * FROM `" + table_name + "` ORDER BY `id`;")
                );
            dataView.DataSource = t;
        }


        public MainForm()
        {
            InitializeComponent();
            
            try
            {
                DBConnection.ConnectionWithDefaultSettings();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                SettingsConnectionForm scf = new SettingsConnectionForm();
                if (scf.ShowDialog() == DialogResult.Cancel)
                {
                    Environment.Exit(93);
                }
            }

            tabControlMain_SelectedIndexChanged(null, null);
        }

        private void AddRecord_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new addSomeOne()).ShowDialog();
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
            LoadSummaryDataGridTable();
        }

        private void LoadSummaryDataGridTable()
        {
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
            
        }


        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.summaryDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void connectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsConnectionForm scf = new SettingsConnectionForm();
            scf.ShowDialog();
        }

        private void exportToWordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SettingsWordExportForm swef = new SettingsWordExportForm();
            SettingsWordExportForm.ShowMe = SummaryTable;
            swef.ShowDialog();
        }

        private void студентToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void руководительToolStripMenuItem_Click(object sender, EventArgs e)
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
        
        private void нуToolStripMenuItem_Click(object sender, EventArgs e)
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


        private void факультетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new EditFaculty()).Show();
        }

        private void кафедрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new EditDivision()).Show();
        }

        private void группыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new EditGroup()).Show();
        }

        private void специальностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new EditSpec()).Show();
        }

        private void руководителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new EditMentor()).Show();
        }

        private void студентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new EditStudent()).Show();
        }


    }
}
