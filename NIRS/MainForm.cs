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

        private void LoadSummaryDataGridTable()
        {
            DataView t = new DataView();
            DataTable tempDataTable = new DataTable();
            tempDataTable.Load(
                    DBConnection.ExecuteReader(
                    @"SELECT CONCAT(s.name,' ',s.fathername, ' ', s.surname) `Студент`, s.born `Дата рождения`,
                        f.name `Факультет`,
                        d.name `Кафедра`,
                        spec.name `Специальность`,
                        g.code `Группа`,
                        CONCAT(m.name, ' ', m.fathername, ' ', m.surname) `Научный руководитель`
                    FROM `student` s
                        JOIN `group` g ON s.group_id = g.id
                        JOIN `spec` spec ON g.spec_id = spec.id
                        JOIN `mentor` m ON s.mentor_id = m.id
                        JOIN `division` d ON spec.div_id = d.id
                        JOIN `faculty` f ON d.fac_id = f.id;"
                    )
                 );
            summaryDataGridView.DataSource = tempDataTable;
            
        }

        private void UpdateAllDataGridView()
        {
            //try
            //{
            LoadSummaryDataGridTable();
            this.groupTableAdapter.Fill(this.nirsDataSetMain.group);
            this.worksTableAdapter.Fill(this.nirsDataSetMain.works);
            this.studentTableAdapter.Fill(this.nirsDataSetMain.student);
            this.mentorTableAdapter.Fill(this.nirsDataSetMain.mentor);
            this.specTableAdapter.Fill(this.nirsDataSetMain.spec);
            this.facultyTableAdapter.Fill(this.nirsDataSetMain.faculty);
            this.divisionTableAdapter.Fill(this.nirsDataSetMain.division);

            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    Close();
            //}
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControlMain.SelectedTab.Text)
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
                default:
                    divisionBindingNavigator.BindingSource = null;
                    //MessageBox.Show(tabControlMain.SelectedTab.Text);
                    break;
            }
            // resize the column once, but allow the ussers to change it.
            this.summaryDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.groupDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.worksDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.studentDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.mentorDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.specDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.facultyDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.divisionDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void divisionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (this.divisionBindingNavigator.BindingSource != null)
            {
                this.Validate();
                this.divisionBindingNavigator.BindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.nirsDataSetMain);
                UpdateAllDataGridView();
            }
        }

        private void connectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsConnectionForm scf = new SettingsConnectionForm();
            scf.ShowDialog();
        }

        private void exportToWordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SettingsWordExportForm swef = new SettingsWordExportForm();
            swef.ShowDialog();
        }
    }
}
