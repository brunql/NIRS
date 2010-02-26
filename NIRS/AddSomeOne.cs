using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NIRS_DB;
using NIRS_DB.Structs;
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
            Mentor ment = new Mentor();
            ment.Name = txtMentorName.Text;
            ment.Surname = txtMentorSurname.Text;
            ment.FatherName = txtMentorFathername.Text;
            if ((iamfrommaycop)cbMentorDivision.SelectedItem == null)
            {
                MessageBox.Show("Кафедра не выбрана");
                return;
            }
            ment.DivisionId = ((iamfrommaycop)cbMentorDivision.SelectedItem).Id;
            ment.AcademicRank = txtMentorAcademicRank.Text;
            ment.Degree = txtMentorDegree.Text;
            ment.Work = txtMentorWork.Text;
            ment.Save();

            MainForm.SelectAllFromAndAdd("mentor", dataViewAddedMentor, new nirsDataSetMain.mentorDataTable());

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

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Student stuff = new Student();
            stuff.Name = txtStudentName.Text;
            stuff.Surname = txtStudentSurname.Text;
            stuff.FatherName = txtStudentFathername.Text;
            try
            {
                stuff.Born = Convert.ToDateTime(txtStudentBirthdayDate.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте правильность ввода даты рождения. " + ex.Message);
                return;
            }
            if (cmbStudentGroup.SelectedItem == null)
            {
                MessageBox.Show("Группа не выбрана");
                return;
            }
            stuff.GroupId = (cmbStudentGroup.SelectedItem as iamfrommaycop).Id;
            if (cmbStudentMentor.SelectedItem == null)
            {
                MessageBox.Show("Руководитель не выбран");
                return;
            }
            stuff.MentorId = (cmbStudentMentor.SelectedItem as iamfrommaycop).Id;
            stuff.Save();

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
            Faculty fac = new Faculty();
            fac.Name = txtAddFaculty.Text;
            fac.Save();

            MainForm.SelectAllFromAndAdd("faculty", dataViewAddedFaculty, new nirsDataSetMain.facultyDataTable());
            MainForm.SelectAllFromAndAdd("faculty", dataViewDivisionFaculty, new nirsDataSetMain.facultyDataTable());
        }

        private void addSomeOne_Load(object sender, EventArgs e)
        {
            MainForm.SelectAllFromAndAdd("faculty", dataViewAddedFaculty, new nirsDataSetMain.facultyDataTable());
            MainForm.SelectAllFromAndAdd("division", dataViewAddedDivision, new nirsDataSetMain.divisionDataTable());
            MainForm.SelectAllFromAndAdd("spec", dataViewAddedSpec, new nirsDataSetMain.specDataTable());
            MainForm.SelectAllFromAndAdd("group", dataViewAddedGroup, new nirsDataSetMain.groupDataTable());
            MainForm.SelectAllFromAndAdd("faculty", dataViewDivisionFaculty, new nirsDataSetMain.facultyDataTable());
            MainForm.SelectAllFromAndAdd("division", dataViewSpecDivision, new nirsDataSetMain.divisionDataTable());
            MainForm.SelectAllFromAndAdd("spec", dataViewGroupSpec, new nirsDataSetMain.specDataTable());
            MainForm.SelectAllFromAndAdd("mentor", dataViewAddedMentor, new nirsDataSetMain.mentorDataTable());
            //cbMentorDivision.Items.Clear();

            for (int i = dataViewSpecDivision.Rows.Count - 1 - 1; i >= 0; i-- )
            {
                iamfrommaycop iam = new iamfrommaycop();
                iam.Id = (int)dataViewSpecDivision.Rows[i].Cells["id"].Value;
                iam.Name = dataViewSpecDivision.Rows[i].Cells["name"].Value.ToString();
                cbMentorDivision.Items.Add(iam);
            }
        }

        private void AddDivision_Click(object sender, EventArgs e)
        {
            Division div = new Division();
            div.Name = txtAddDivision.Text;
            div.FacId = (int)dataViewDivisionFaculty.CurrentRow.Cells["id"].Value;
            div.Save();
            
            MainForm.SelectAllFromAndAdd("division", dataViewAddedDivision, new nirsDataSetMain.divisionDataTable());
            MainForm.SelectAllFromAndAdd("faculty", dataViewDivisionFaculty, new nirsDataSetMain.facultyDataTable());
        }

        private void AddSpec_Click(object sender, EventArgs e)
        {
            Specialization spec = new Specialization();
            spec.Name = txtAddSpecFullName.Text;
            spec.Code = txtAddSpec.Text;
            spec.DivisionId = (int)dataViewSpecDivision.CurrentRow.Cells["id"].Value;
            spec.Save();

            MainForm.SelectAllFromAndAdd("spec", dataViewAddedSpec, new nirsDataSetMain.specDataTable());
            MainForm.SelectAllFromAndAdd("division", dataViewSpecDivision, new nirsDataSetMain.divisionDataTable());
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            Group group = new Group();
            group.DivisionId = (int)dataViewGroupSpec.CurrentRow.Cells["id"].Value;
            group.Code = txtAddGroupCode.Text;
            group.Save();

            MainForm.SelectAllFromAndAdd("group", dataViewAddedGroup, new nirsDataSetMain.groupDataTable());
            MainForm.SelectAllFromAndAdd("spec", dataViewGroupSpec, new nirsDataSetMain.specDataTable());
        }


        private void tabPage1_Enter(object sender, EventArgs e)
        {
            iamfrommaycop.FillComboBox(dataViewAddedFaculty, cmbStudentFaculty);
            // todo: load mentors to cmbStudentMentors
            //iamfrommaycop.FillComboBox(dataViewAddedDivision, cmbStudentDivision);
            //iamfrommaycop.FillComboBox(dataViewAddedGroup, cmbStudentGroup);
            //iamfrommaycop.FillComboBox(dat
            for (int i = dataViewSpecDivision.Rows.Count - 1 - 1; i >= 0; i--)
            {
                iamfrommaycop iam = new iamfrommaycop();
                iam.Id = (int)dataViewSpecDivision.Rows[i].Cells["id"].Value;
                iam.Name = dataViewSpecDivision.Rows[i].Cells["name"].Value.ToString();
                cbMentorDivision.Items.Add(iam);
            }
        }

        private void cmbStudentFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbStudentDivision.Enabled = true;
            iamfrommaycop.FillComboBoxWithCmp(dataViewAddedDivision, cmbStudentDivision,"name", "fac_id", (cmbStudentFaculty.SelectedItem as iamfrommaycop).Id);
        }

        private void cmbStudentDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbStudentSpetialize.Enabled = true;
            iamfrommaycop.FillComboBoxWithCmp(dataViewAddedSpec, cmbStudentSpetialize, "name", "div_id", (cmbStudentDivision.SelectedItem as iamfrommaycop).Id);
        }

        private void cmbStudentSpetialize_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbStudentGroup.Enabled = true;
            iamfrommaycop.FillComboBoxWithCmp(dataViewAddedGroup, cmbStudentGroup, "code", "div_id", (cmbStudentDivision.SelectedItem as iamfrommaycop).Id);
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            iamfrommaycop.FillComboBox_SPECIAL_FOR_MENTOR_REWRITE_ME(dataViewAddedMentor, cmbStudentMentor);
        }
    }

    class iamfrommaycop
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
                iamfrommaycop iam = new iamfrommaycop();
                iam.Id = (int)dtvw.Rows[i].Cells["id"].Value;
                iam.Name = dtvw.Rows[i].Cells["name"].Value.ToString();
                cb.Items.Add(iam);
            }
        }

        public static void FillComboBox_SPECIAL_FOR_MENTOR_REWRITE_ME(DataGridView dtvw, ComboBox cb)
        {
            cb.Items.Clear();
            for (int i = dtvw.Rows.Count - 1 - 1; i >= 0; i--)
            {
                iamfrommaycop iam = new iamfrommaycop();
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
                    iamfrommaycop iam = new iamfrommaycop();
                    iam.Id = (int)dtvw.Rows[i].Cells["id"].Value;
                    iam.Name = dtvw.Rows[i].Cells[col_name].Value.ToString();
                    cb.Items.Add(iam);
                }
            }
        }
    }
}
