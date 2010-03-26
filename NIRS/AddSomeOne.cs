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

            InsertStuff.InsertMentor(txtMentorName.Text,
                txtMentorSurname.Text,
                txtStudentFathername.Text,
                txtMentorWork.Text,
                txtMentorAcademicRank.Text,
                txtMentorDegree.Text,
                ((ComboBoxKiller)cbMentorDivision.SelectedItem).Id
                );

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
            
            if (cmbStudentMentor.SelectedItem == null)
            {
                MessageBox.Show("Руководитель не выбран");
                return;
            }

            InsertStuff.InsertStudent(
                txtStudentName.Text,
                txtStudentSurname.Text,
                txtStudentFathername.Text,
                (cmbStudentGroup.SelectedItem as ComboBoxKiller).Id,
                (cmbStudentMentor.SelectedItem as ComboBoxKiller).Id,
                birthdate
                );



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
            InsertStuff.InsertFaculty(txtAddFacultyName.Text, txtAddFacultyFullName.Text);
        }

        private void addSomeOne_Load(object sender, EventArgs e)
        {
            for (int i = dataViewSpecDivision.Rows.Count - 1 - 1; i >= 0; i-- )
            {
                ComboBoxKiller iam = new ComboBoxKiller();
                iam.Id = (int)dataViewSpecDivision.Rows[i].Cells["id"].Value;
                iam.Name = dataViewSpecDivision.Rows[i].Cells["name"].Value.ToString();
                cbMentorDivision.Items.Add(iam);
            }
        }

        private void AddDivision_Click(object sender, EventArgs e)
        {
            InsertStuff.InsertDivision(
                (int)dataViewDivisionFaculty.CurrentRow.Cells["id"].Value,
                txtAddDivision.Text,
                txtAddDivisionFullName.Text
                );
        }

        private void AddSpec_Click(object sender, EventArgs e)
        {
            InsertStuff.InsertSpecialize(
                (int)dataViewSpecDivision.CurrentRow.Cells["id"].Value,
                txtAddSpec.Text,
                txtAddSpecFullName.Text
                );
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            InsertStuff.InsertGroup(
                (int)dataViewGroupSpec.CurrentRow.Cells["id"].Value,
                txtAddGroupCode.Text
                );
        }


        private void tabPage1_Enter(object sender, EventArgs e)
        {
            ComboBoxKiller.FillComboBox(dataGridViewFaculty, cmbStudentFaculty);
            // todo: load mentors to cmbStudentMentors
            //ComboBoxKiller.FillComboBox(dataViewAddedDivision, cmbStudentDivision);
            //ComboBoxKiller.FillComboBox(dataViewAddedGroup, cmbStudentGroup);
            //ComboBoxKiller.FillComboBox(dat
            for (int i = dataViewSpecDivision.Rows.Count - 1 - 1; i >= 0; i--)
            {
                ComboBoxKiller iam = new ComboBoxKiller();
                iam.Id = (int)dataViewSpecDivision.Rows[i].Cells["id"].Value;
                iam.Name = dataViewSpecDivision.Rows[i].Cells["name"].Value.ToString();
                cbMentorDivision.Items.Add(iam);
            }
        }

        private void cmbStudentFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbStudentDivision.Enabled = true;
            ComboBoxKiller.FillComboBoxWithCmp(dataViewAddedDivision, cmbStudentDivision,"name", "fac_id", (cmbStudentFaculty.SelectedItem as ComboBoxKiller).Id);
        }

        private void cmbStudentDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbStudentSpetialize.Enabled = true;
            ComboBoxKiller.FillComboBoxWithCmp(dataViewAddedSpec, cmbStudentSpetialize, "name", "div_id", (cmbStudentDivision.SelectedItem as ComboBoxKiller).Id);
        }

        private void cmbStudentSpetialize_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbStudentGroup.Enabled = true;
            ComboBoxKiller.FillComboBoxWithCmp(dataViewAddedGroup, cmbStudentGroup, "code", "spec_id", (cmbStudentDivision.SelectedItem as ComboBoxKiller).Id);
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            ComboBoxKiller.FillComboBox_mentor(dataViewAddedMentor, cmbStudentMentor);
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
            for (int i = dtvw.Rows.Count - 1 - 1; i >= 0; i--)
            {
                ComboBoxKiller iam = new ComboBoxKiller();
                iam.Id = (int)dtvw.Rows[i].Cells["id"].Value;
                iam.Name = dtvw.Rows[i].Cells["name"].Value.ToString();
                cb.Items.Add(iam);
            }
        }

        public static void FillComboBox_mentor(DataGridView dtvw, ComboBox cb)
        {
            cb.Items.Clear();
            for (int i = dtvw.Rows.Count - 1 - 1; i >= 0; i--)
            {
                ComboBoxKiller iam = new ComboBoxKiller();
                iam.Id = (int)dtvw.Rows[i].Cells["id"].Value;
                iam.Name = dtvw.Rows[i].Cells["name"].Value.ToString() +" "+
                    dtvw.Rows[i].Cells["surname"].Value.ToString() + " "+
                    dtvw.Rows[i].Cells["fathername"].Value.ToString();
                cb.Items.Add(iam);
            }
        }

        public static void FillComboBoxWithCmp(DataGridView dtvw, ComboBox cb, string col_name, string thatCmp, int idCmp)
        {
            cb.Items.Clear();
            for (int i = dtvw.Rows.Count - 1 - 1; i >= 0; i--)
            {
                if ((int)dtvw.Rows[i].Cells[thatCmp].Value == idCmp)
                {
                    ComboBoxKiller iam = new ComboBoxKiller();
                    iam.Id = (int)dtvw.Rows[i].Cells["id"].Value;
                    iam.Name = dtvw.Rows[i].Cells[col_name].Value.ToString();
                    cb.Items.Add(iam);
                }
            }
        }
    }
}
