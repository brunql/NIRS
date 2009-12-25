//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Windows.Forms;
//using NIRS_DB;
//using NIRS_DB.Structs;
//using MySql.Data.MySqlClient;


//namespace NIRS
//{
//    public partial class addSomeOne : Form
//    {

//        public addSomeOne()
//        {
//            InitializeComponent();
//        }

//        private void cmbFaculty_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            // TODO: обновить кафедры
//        }
        
//        private void cmbStudentKurs_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            // TODO: обновить специальности
//        }
        
//        private void ckbMoney_CheckedChanged(object sender, EventArgs e)
//        {
//            txtStudentGrant.Text = "";
//            txtStudentGrant.Enabled = ckbMoney.Checked;
//        }

//        private void btnAddMentor_Click(object sender, EventArgs e)
//        {
//            Mentor ment = new Mentor();
//            ment.Name = txtMentorName.Text;
//            ment.Surname = txtMentorSurname.Text;
//            ment.FatherName = txtMentorFathername.Text;
//            //if ((Division)cbMentorDivision.SelectedItem == null)
//            //{
//            //    MessageBox.Show("Кафедра не выбрана");
//            //    return;
//            //}
//            //ment.Division = (Division)cbMentorDivision.SelectedItem;
//            ment.AcademicRank = txtMentorAcademicRank.Text;
//            ment.Degree = txtMentorDegree.Text;
//            ment.Work = txtMentorWork.Text;
//            ment.Save();
            
//            DialogResult result = MessageBox.Show("Руководитель добавлен. Очистить поля?", "Добавление", MessageBoxButtons.YesNo);
//            if (result == DialogResult.Yes)
//            {
//                txtMentorSurname.Text = "";
//                txtMentorFathername.Text = "";
//                txtMentorName.Text = "";
//                txtMentorWork.Text = "";
//                txtMentorDegree.Text = "";
//                txtMentorAcademicRank.Text = "";
//            }
//        }

//        private void btnAddStudent_Click(object sender, EventArgs e)
//        {
//            Student stuff = new Student();
//            stuff.Name = txtStudentName.Text;
//            stuff.Surname = txtStudentSurname.Text;
//            stuff.FatherName = txtStudentFathername.Text;
//            try
//            {
//                stuff.Born = Convert.ToDateTime(txtStudentBirthdayDate);
//            }
//            catch(Exception ex)
//            {
//                MessageBox.Show("Проверьте правильность ввода даты рождения. " + ex.Message);
//                return;
//            }
//            if ((Group)cmbStudentGroup.SelectedItem == null)
//            {
//                MessageBox.Show("Группа не выбрана");
//                return;
//            }
//            stuff.Group = (Group) cmbStudentGroup.SelectedItem;
//            if ((Mentor)cmbStudentMentor.SelectedItem == null)
//            {
//                MessageBox.Show("Руководитель не выбран");
//                return;
//            }
//            stuff.Mentor = (Mentor) cmbStudentMentor.SelectedItem;
//            stuff.Save();

//            DialogResult result = MessageBox.Show("Студент добавлен. Очистить поля?", "Добавление", MessageBoxButtons.YesNo);
//            if (result == DialogResult.Yes)
//            {
//                txtStudentSurname.Text = "";
//                txtStudentFathername.Text = "";
//                txtStudentName.Text = "";
//                txtStudentGrant.Text = "";
//                txtStudentPatents.Text = "";
//                txtStudentProgramCount.Text = "";
//                txtStudentPublicationCount.Text = "";
//                txtStudentAsset.Text = "";
//            }
//        }

//        private void btnFacultyAdded_Click(object sender, EventArgs e)
//        {
//            Faculty fac = new Faculty();
//            fac.Name = txtAddFaculty.Text;
//            fac.Save();

//            MainForm.SelectAllFromAndAdd("faculty", dataViewAddedFaculty, new nirsDataSet.facultyDataTable());
//            MainForm.SelectAllFromAndAdd("faculty", dataViewDivisionFaculty, new nirsDataSet.facultyDataTable());
//        }

//        private void addSomeOne_Load(object sender, EventArgs e)
//        {
//            MainForm.SelectAllFromAndAdd("faculty", dataViewAddedFaculty, new nirsDataSet.facultyDataTable());
//            //dataViewAddedFaculty.Columns.RemoveAt(0);

//            MainForm.SelectAllFromAndAdd("division", dataViewAddedDivision, new nirsDataSet.divisionDataTable());
//            //dataViewAddedDivision.Columns.RemoveAt(0);

//            MainForm.SelectAllFromAndAdd("spec", dataViewAddedSpec, new nirsDataSet.specDataTable());
//            //dataViewAddedSpec.Columns.RemoveAt(0);

//            MainForm.SelectAllFromAndAdd("group", dataViewAddedGroup, new nirsDataSet.groupDataTable());
//            //dataViewAddedGroup.Columns.RemoveAt(0);

//            MainForm.SelectAllFromAndAdd("faculty", dataViewDivisionFaculty, new nirsDataSet.facultyDataTable());
//            //dataViewDivisionFaculty.Columns.RemoveAt(0);
//            MainForm.SelectAllFromAndAdd("division", dataViewSpecDivision, new nirsDataSet.divisionDataTable());
//            MainForm.SelectAllFromAndAdd("spec", dataViewGroupSpec, new nirsDataSet.specDataTable());
//        }

//        private void AddDivision_Click(object sender, EventArgs e)
//        {
//            Division div = new Division();
//            div.Name = txtAddFaculty.Text;
//            div.FacId = (int)dataViewDivisionFaculty.SelectedRows[0].Cells[0].Value;
//            div.Save();


//            MainForm.SelectAllFromAndAdd("division", dataViewAddedDivision, new nirsDataSet.divisionDataTable());
//            //dataViewAddedDivision.Columns.RemoveAt(0);

//            MainForm.SelectAllFromAndAdd("faculty", dataViewDivisionFaculty, new nirsDataSet.facultyDataTable());
//            //dataViewDivisionFaculty.Columns.RemoveAt(0);
//        }

//        private void AddSpec_Click(object sender, EventArgs e)
//        {
//            Specialization spec = new Specialization();
//            spec.Name = txtAddSpec.Text;
//            spec.Save();

//            MainForm.SelectAllFromAndAdd("spec", dataViewAddedSpec, new nirsDataSet.specDataTable());
//            //dataViewAddedSpec.Columns.RemoveAt(0);

//            MainForm.SelectAllFromAndAdd("division", dataViewSpecDivision, new nirsDataSet.divisionDataTable());
//            // TODO: добавить кафедру и код специальности
//        }

//        private void btnAddGroup_Click(object sender, EventArgs e)
//        {
//            Group group = new Group();            
//            group.DivisionId = (int)dataViewGroupSpec.SelectedRows[0].Cells[0].Value;
//            group.Code = txtAddGroupCode.Text;

//            group.Save();
            
//            MainForm.SelectAllFromAndAdd("group", dataViewAddedGroup, new nirsDataSet.groupDataTable());
//            MainForm.SelectAllFromAndAdd("spec", dataViewGroupSpec, new nirsDataSet.specDataTable());
//        }
//    }
//}
