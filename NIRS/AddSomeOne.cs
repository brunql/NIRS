using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using NIRS_DB;
using MySql.Data.MySqlClient;


namespace NIRS
{
    public partial class addSomeOne : Form
    {

        public addSomeOne()
        {
            InitializeComponent();
        }


        private void ckbMoney_CheckedChanged(object sender, EventArgs e)
        {
            txtStudentGrant.Text = "";
            txtStudentGrant.Enabled = ckbMoney.Checked;
        }

        private void btnAddMentor_Click(object sender, EventArgs e)
        {
            if ((ComboBoxKiller)cbMentorDivision.SelectedItem == null)
            {
                MessageBox.Show("Кафедра не выбрана");
                return;
            }


            if (((ComboBoxKiller)cbMentorDivision.SelectedItem).Id < 0)
            {
                MessageBox.Show("cbMentorDivision.Id < 0");
                return;
            }

            NIRS_Viewer.config.NIRS_DataSet.mentor.AddmentorRow(
//            InsertStuff.InsertMentor(
                txtMentorName.Text,
                txtMentorSurname.Text,
                txtStudentFathername.Text,
                txtMentorWork.Text,
                txtMentorAcademicRank.Text,
                txtMentorDegree.Text,
                ((ComboBoxKiller)cbMentorDivision.SelectedItem).Id
                );
            bindMentor.Save();

            DialogResult result = MessageBox.Show("Руководитель добавлен. Очистить поля?", "Добавление", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                txtMentorSurname.Text = "";
                txtMentorFathername.Text = "";
                txtMentorName.Text = "";
                txtMentorWork.Text = "";
                txtMentorDegree.Text = "";
                txtMentorAcademicRank.Text = "";
            }

        }

        private void ShowError(string text)
        {
            MessageBox.Show("Проверьте правильность ввода данных: " + text, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            throw new NullReferenceException();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStudentName.Text.Trim() == "") ShowError("имя");
                if (txtStudentSurname.Text.Trim() == "") ShowError("фамилия");
                if (txtStudentFathername.Text.Trim() == "") ShowError("отчество");
            }
            catch // if error show only one error message and return
            {
                return; 
            }

            DateTime birthdate = new DateTime();
            try
            {
                birthdate = Convert.ToDateTime(txtStudentBirthdayDate.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Проверьте правильность ввода даты рождения.");
                return;
            }
            if (cmbStudentGroup.SelectedItem == null)
            {
                MessageBox.Show("Группа не выбрана");
                return;
            }

            if (((ComboBoxKiller)cmbStudentGroup.SelectedItem).Id < 0)
            {
                MessageBox.Show("cmbStudentGroup.Id < 0");
                return;
            }

            NIRS_Viewer.config.NIRS_DataSet.student.AddstudentRow(
            //InsertStuff.InsertStudent(
                txtStudentName.Text,
                txtStudentSurname.Text,
                txtStudentFathername.Text,
                (cmbStudentGroup.SelectedItem as ComboBoxKiller).Id,
                birthdate,
                cmbStudentBudget.Text,
                (txtStudentGrant.Text == "") ? "Нет" : txtStudentGrant.Text
                );
            bindStudent.Save();

            DialogResult result = MessageBox.Show("Студент добавлен. Очистить поля?", "Добавление", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                txtStudentSurname.Text = "";
                txtStudentFathername.Text = "";
                txtStudentName.Text = "";
                txtStudentGrant.Text = "";
                txtStudentPatents.Text = "";
                txtStudentProgramCount.Text = "";
                txtStudentPublicationCount.Text = "";
                txtStudentAsset.Text = "";
            }
        }

        private void btnFacultyAdded_Click(object sender, EventArgs e)
        {
            NIRS_Viewer.config.NIRS_DataSet.faculty.AddfacultyRow(txtAddFacultyName.Text, txtAddFacultyFullName.Text);
            bindFaculty.Save();
            
            //MySqlCommand command = new MySqlCommand(@"SELECT MAX(`id`) FROM `faculty`;", NIRS_Viewer.config.NIRS_MySqlConnection);
            //NIRS_Viewer.config.NIRS_MySqlConnection.Open();
            //MySqlDataReader reader = command.ExecuteReader();
            //reader.Read();
            //int id = reader.GetInt32(0);
            //reader.Close();
            //NIRS_Viewer.config.NIRS_MySqlConnection.Close();

            //newrow.id = id;
            
            //InsertStuff.InsertFaculty(txtAddFacultyName.Text, txtAddFacultyFullName.Text);
            //object[] vals = {
            //        -1, txtAddFacultyName.Text, txtAddFacultyFullName.Text
            //};
            //NIRS_Viewer.config.NIRS_DataSet.Tables["faculty"].LoadDataRow(vals, true);
            //bindFaculty.Save();
            //NIRS_Viewer.config.NIRS_DataSet.AcceptChanges();
            
            //NIRS_Viewer.config.InsertFaculty(txtAddFacultyName.Text, txtAddFacultyFullName.Text);
            //NIRS_Viewer.config.Save("faculty");
            //bindFaculty.Save();
        }

        private void addSomeOne_Load(object sender, EventArgs e)
        {
            bindFaculty.Fill();
            ComboBoxKiller.FillComboBox(dataViewAddedDivision, cbMentorDivision);
        }

        private void AddDivision_Click(object sender, EventArgs e)
        {
            if ((int)dataViewDivisionFaculty.CurrentRow.Cells[0].Value < 0)
            {
                // fuck fuck fuck !!!!!!!
                // this sucks!!!
                // i don't know that todo to make it work as it must! :'(
                MessageBox.Show("(int)dataViewDivisionFaculty.CurrentRow.Cells[0].Value < 0");
                return; 
            }

            NIRS_Viewer.config.NIRS_DataSet.division.AdddivisionRow(
            //InsertStuff.InsertDivision(
                (int)dataViewDivisionFaculty.CurrentRow.Cells[0].Value,
                txtAddDivision.Text,
                txtAddDivisionFullName.Text
                );
            bindDivision.Save();
        }

        private void AddSpec_Click(object sender, EventArgs e)
        {
            if ((int)dataViewSpecDivision.CurrentRow.Cells[0].Value < 0)
            {
                MessageBox.Show("(int)dataViewSpecDivision.CurrentRow.Cells[0].Value < 0");
                return;
            }
            NIRS_Viewer.config.NIRS_DataSet.spec.AddspecRow(
            //InsertStuff.InsertSpecialize(
                (int)dataViewSpecDivision.CurrentRow.Cells[0].Value,
                txtAddSpec.Text,
                txtAddSpecFullName.Text
                );

            bindSpec.Save();
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            if ((int)dataViewGroupSpec.CurrentRow.Cells[0].Value < 0)
            {
                MessageBox.Show("(int)dataViewGroupSpec.CurrentRow.Cells[0].Value < 0");
                return;
            }
            NIRS_Viewer.config.NIRS_DataSet.group.AddgroupRow(
            //InsertStuff.InsertGroup(
                (int)dataViewGroupSpec.CurrentRow.Cells[0].Value,
                txtAddGroupCode.Text
                );
            bindGroup.Save();
        }


        private void tabPage1_Enter(object sender, EventArgs e)
        {
            ComboBoxKiller.FillComboBox(dataGridViewFaculty, cmbStudentFaculty);
            ComboBoxKiller.FillComboBox(dataViewAddedDivision, cbMentorDivision);
        }

        private void cmbStudentFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbStudentDivision.Enabled = true;
            ComboBoxKiller.FillComboBoxWithCmp(dataViewAddedDivision, cmbStudentDivision, 2, 1, (cmbStudentFaculty.SelectedItem as ComboBoxKiller).Id);
        }

        private void cmbStudentDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbStudentSpetialize.Enabled = true;
            ComboBoxKiller.FillComboBoxWithCmp(dataViewAddedSpec, cmbStudentSpetialize, 2, 1, (cmbStudentDivision.SelectedItem as ComboBoxKiller).Id);
        }

        private void cmbStudentSpetialize_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbStudentGroup.Enabled = true;
            ComboBoxKiller.FillComboBoxWithCmp(dataViewAddedGroup, cmbStudentGroup, 2, 1, (cmbStudentSpetialize.SelectedItem as ComboBoxKiller).Id);
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            ComboBoxKiller.FillComboBox_MentorStudent(dataViewAddedMentor, cmbNIR_Mentor);
            ComboBoxKiller.FillComboBox_MentorStudent(dataViewAddedStudent, cmbNIR_Student);
        }

        private void btnAddStudentNIR_Click(object sender, EventArgs e)
        {
            if (cmbNIR_Student.SelectedItem as ComboBoxKiller == null)
            {
                MessageBox.Show("Студент не выбран");
                return;
            }
            if (cmbNIR_Mentor.SelectedItem as ComboBoxKiller == null)
            {
                MessageBox.Show("Руководитель не выбран");
                return;
            }

            if ((cmbNIR_Student.SelectedItem as ComboBoxKiller).Id < 0)
            {
                MessageBox.Show("(cmbNIR_Student.SelectedItem as ComboBoxKiller).Id < 0");
                return;
            }

            if ((cmbNIR_Mentor.SelectedItem as ComboBoxKiller).Id < 0)
            {
                MessageBox.Show("(cmbNIR_Mentor.SelectedItem as ComboBoxKiller).Id < 0");
                return;
            }

            NIRS_Viewer.config.NIRS_DataSet.works.AddworksRow(
            //InsertStuff.InsertScienceWork(
                (cmbNIR_Student.SelectedItem as ComboBoxKiller).Id,
                rtbxStudentTheme.Text,
                rtbxStudentBackLog.Text,
                (cmbNIR_Mentor.SelectedItem as ComboBoxKiller).Id
                );
        }

    }

    class ComboBoxKiller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }

        public static void FillComboBox(DataGridView dtvw, ComboBox cb)
        {
            cb.Items.Clear();
            for (int i = (dtvw.Rows.Count - 1); i >= 0; i--)
            {
                ComboBoxKiller iam = new ComboBoxKiller();
                iam.Id = (int)dtvw.Rows[i].Cells[0].Value;
                iam.Name = dtvw.Rows[i].Cells[2].Value.ToString();
                cb.Items.Add(iam);
            }
        }

        public static void FillComboBox_MentorStudent(DataGridView dtvw, ComboBox cb)
        {
            cb.Items.Clear();
            for (int i = dtvw.Rows.Count - 1; i >= 0; i--)
            {
                ComboBoxKiller iam = new ComboBoxKiller();
                iam.Id = (int)dtvw.Rows[i].Cells[0].Value;
                iam.Name = dtvw.Rows[i].Cells[1].Value.ToString() + " " +
                    dtvw.Rows[i].Cells[2].Value.ToString() + " " +
                    dtvw.Rows[i].Cells[3].Value.ToString();
                cb.Items.Add(iam);
            }
        }

        public static void FillComboBoxWithCmp(DataGridView dtvw, ComboBox cb, int col_indx, int thatCmp_indx, int idCmp)
        {
            cb.Items.Clear();
            for (int i = dtvw.Rows.Count - 1; i >= 0; i--)
            {
                if ((int)dtvw.Rows[i].Cells[thatCmp_indx].Value == idCmp)
                {
                    ComboBoxKiller iam = new ComboBoxKiller();
                    iam.Id = (int)dtvw.Rows[i].Cells[0].Value;
                    iam.Name = dtvw.Rows[i].Cells[col_indx].Value.ToString();
                    cb.Items.Add(iam);
                }
            }
        }
    }
}
