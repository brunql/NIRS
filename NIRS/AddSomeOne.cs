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
    public partial class AddSomeOne : Form
    {
        private NIRS_Viewer.bind bindFaculty;
        private NIRS_Viewer.bind bindDivision;
        private NIRS_Viewer.bind bindSpec;
        private NIRS_Viewer.bind bindGroup;
        private NIRS_Viewer.bind bindMentor;
        //private NIRS_Viewer.bind bindStudent;
        private NIRS_Viewer.bind bindWorks;
        


        public AddSomeOne()
        {
            try
            {
                InitializeComponent();
                
                this.bindFaculty = new NIRS_Viewer.bind();
                this.bindFaculty.DataMember = "faculty";
                this.bindFaculty.Position = 0;

                this.bindDivision = new NIRS_Viewer.bind();
                this.bindDivision.DataMember = "division";
                this.bindDivision.Position = 0;

                this.bindSpec = new NIRS_Viewer.bind();
                this.bindSpec.DataMember = "spec";
                this.bindSpec.Position = 0;

                this.bindGroup = new NIRS_Viewer.bind();
                this.bindGroup.DataMember = "group";
                this.bindGroup.Position = 0;

                this.bindMentor = new NIRS_Viewer.bind();
                this.bindMentor.DataMember = "mentor";
                this.bindMentor.Position = 0;

                //this.bindStudent = new NIRS_Viewer.bind();
                //this.bindStudent.DataMember = "student";
                //this.bindStudent.Position = 0;

                this.bindWorks = new NIRS_Viewer.bind();
                this.bindWorks.DataMember = "works";
                this.bindWorks.Position = 0;


                this.dataViewFaculty.DataSource = this.bindFaculty;
                this.dataViewDivisionFaculty.DataSource = this.bindFaculty;
                this.dataViewAddedDivision.DataSource = this.bindDivision;
                this.dataViewSpecDivision.DataSource = this.bindDivision;
                this.dataViewAddedSpec.DataSource = this.bindSpec;
                this.dataViewGroupSpec.DataSource = this.bindSpec;
                this.dataViewAddedGroup.DataSource = this.bindGroup;
                this.dataViewAddedMentor.DataSource = this.bindMentor;
                //this.dataViewAddedStudent.DataSource = this.bindStudent;

                DataGridInitializer.InitFaculty(this.dataViewFaculty);
                DataGridInitializer.InitFaculty(this.dataViewDivisionFaculty);
                DataGridInitializer.InitDivision(this.dataViewAddedDivision);
                DataGridInitializer.InitDivision(this.dataViewSpecDivision);
                DataGridInitializer.InitSpec(this.dataViewAddedSpec);
                DataGridInitializer.InitSpec(this.dataViewGroupSpec);
                DataGridInitializer.InitGroup(this.dataViewAddedGroup);
                DataGridInitializer.InitMentor(this.dataViewAddedMentor);
                //DataGridInitializer.InitStudent(this.dataViewAddedStudent);
            }
            catch(Exception ex)
            {
                Logs.WriteLine(ex.ToString());
                MessageBox.Show("Проблемы при инициализации окна добавления записей. Проверьте запущена ли база данных. Сообщение об ошибке: " + ex.Message);
                this.Close();
            }
        }

        private void ShowError(string text)
        {
            MessageBox.Show("Проверьте правильность ввода данных: " + text, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            throw new NullReferenceException();
        }

        private void addSomeOne_Load(object sender, EventArgs e)
        {
            try
            {
                // здесь можно немного пошалить ;)
                cmbMentorDivision.DataSource = bindDivision;
                cmbMentorDivision.DisplayMember = "name";

                //cmbNIR_Mentor.DataSource = bindMentor;
                //cmbNIR_Mentor.DisplayMember = "secondname";
            }
            catch (Exception ex)
            {
                Logs.WriteLine(ex.ToString());
            }
        }




        private void btnAddFaculty_Click(object sender, EventArgs e)
        {
            try
            {
                NIRS_Viewer.config.NIRS_DataSet.faculty.AddfacultyRow(
                    txtAddFacultyName.Text,
                    txtAddFacultyFullName.Text);
                bindFaculty.Save();

                DialogResult result = MessageBox.Show("Факультет добавлен. Очистить поля?", "Добавление", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    txtAddFacultyName.Text = "";
                    txtAddFacultyFullName.Text = "";
                }
            }
            catch (Exception ex)
            {
                Logs.WriteLine(ex.ToString());
            }
        }

        private void btnAddDivision_Click(object sender, EventArgs e)
        {
            try
            {
                NIRS_Viewer.config.NIRS_DataSet.division.AdddivisionRow(
                    (int)dataViewDivisionFaculty.CurrentRow.Cells[0].Value,
                    txtAddDivision.Text,
                    txtAddDivisionFullName.Text
                    );
                bindDivision.Save();

                DialogResult result = MessageBox.Show("Кафедра добавлена. Очистить поля?", "Добавление", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    txtAddDivision.Text = "";
                    txtAddDivisionFullName.Text = "";
                }
            }
            catch (Exception ex)
            {
                Logs.WriteLine(ex.ToString());
            }
        }

        private void btnAddSpec_Click(object sender, EventArgs e)
        {
            try
            {
                NIRS_Viewer.config.NIRS_DataSet.spec.AddspecRow(
                    (int)dataViewSpecDivision.CurrentRow.Cells[0].Value,
                    txtAddSpec.Text,
                    txtAddSpecFullName.Text
                    );

                bindSpec.Save();

                DialogResult result = MessageBox.Show("Специальность добавлена. Очистить поля?", "Добавление", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    txtAddSpec.Text = "";
                    txtAddSpecFullName.Text = "";
                }
            }
            catch (Exception ex)
            {
                Logs.WriteLine(ex.ToString());
            }
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            try
            {
                NIRS_Viewer.config.NIRS_DataSet.group.AddgroupRow(
                    (int)dataViewGroupSpec.CurrentRow.Cells[0].Value,
                    txtAddGroupCode.Text
                    );
                bindGroup.Save();

                DialogResult result = MessageBox.Show("Группа добавлена. Очистить поля?", "Добавление", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    txtAddGroupCode.Text = "";
                }
            }
            catch (Exception ex)
            {
                Logs.WriteLine(ex.ToString());
            }
        }


        private void btnAddMentor_Click(object sender, EventArgs e)
        {
            try
            {
                if (((DataRowView)cmbMentorDivision.SelectedItem) == null)//((ComboBoxKiller)cmbMentorDivision.SelectedItem == null)
                {
                    MessageBox.Show("Кафедра не выбрана");
                    return;
                }


                NIRS_Viewer.config.NIRS_DataSet.mentor.AddmentorRow(
                    txtMentorName.Text,
                    txtMentorSurname.Text,
                    txtMentorFathername.Text,
                    txtMentorWork.Text,
                    txtMentorAcademicRank.Text,
                    txtMentorDegree.Text,
                    (int)((DataRowView)cmbMentorDivision.SelectedItem).Row[0] // get id
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
            catch (Exception ex)
            {
                Logs.WriteLine(ex.ToString());
            }
        }

        //private void btnAddStudent_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (txtStudentName.Text.Trim() == "") ShowError("имя");
        //        if (txtStudentSurname.Text.Trim() == "") ShowError("фамилия");
        //        if (txtStudentFathername.Text.Trim() == "") ShowError("отчество");
        //    }
        //    catch // if error show only one error message and return
        //    {
        //        return;
        //    }
        //    try
        //    {
        //        DateTime birthdate = new DateTime();
        //        try
        //        {
        //            birthdate = dateTimePickerStudent.Value; //Convert.ToDateTime(txtStudentBirthdayDate.Text);
        //        }
        //        catch (FormatException)
        //        {
        //            MessageBox.Show("Проверьте правильность ввода даты рождения.");
        //            return;
        //        }
        //        if (cmbStudentGroup.SelectedItem == null)
        //        {
        //            MessageBox.Show("Группа не выбрана");
        //            return;
        //        }

        //        if (((ComboBoxKiller)cmbStudentGroup.SelectedItem).Id < 0)
        //        {
        //            MessageBox.Show("cmbStudentGroup.Id < 0");
        //            return;
        //        }

        //        NIRS_Viewer.config.NIRS_DataSet.student.AddstudentRow(
        //            txtStudentName.Text,
        //            txtStudentSurname.Text,
        //            txtStudentFathername.Text,
        //            (cmbStudentGroup.SelectedItem as ComboBoxKiller).Id,
        //            birthdate,
        //            cmbStudentBudget.Text,
        //            ((txtStudentGrant.Text == "") ? "Нет" : txtStudentGrant.Text),
        //            txtStudentEmail.Text,
        //            txtStudentPhone.Text,
        //            "gpa",
        //            9,
        //            "science theme",
        //            "address home",
        //            "science works",
        //            0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 
        //            "awards for scientific work", 
        //            true, true,true
        //            );
        //        bindStudent.Save();

        //        DialogResult result = MessageBox.Show("Студент добавлен. Очистить поля?", "Добавление", MessageBoxButtons.YesNo);
        //        if (result == DialogResult.Yes)
        //        {
        //            txtStudentSurname.Text = "";
        //            txtStudentFathername.Text = "";
        //            txtStudentName.Text = "";
        //            txtStudentGrant.Text = "";
        //            txtStudentBirthdayDate.Text = "";
        //            txtStudentPatents.Text = "";
        //            txtStudentProgramCount.Text = "";
        //            txtStudentPublicationCount.Text = "";
        //            txtStudentAsset.Text = "";
        //            txtStudentEmail.Text = "";
        //            txtStudentPhone.Text = "";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Logs.WriteLine(ex.ToString());
        //    }
        //}

        //private void btnAddWorksNIR_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (cmbNIR_Student.SelectedItem as ComboBoxKiller == null)
        //        {
        //            MessageBox.Show("Студент не выбран");
        //            return;
        //        }
        //        if (cmbNIR_Mentor.SelectedItem as ComboBoxKiller == null)
        //        {
        //            MessageBox.Show("Руководитель не выбран");
        //            return;
        //        }

        //        if ((cmbNIR_Student.SelectedItem as ComboBoxKiller).Id < 0)
        //        {
        //            MessageBox.Show("(cmbNIR_Student.SelectedItem as ComboBoxKiller).Id < 0");
        //            return;
        //        }

        //        if ((cmbNIR_Mentor.SelectedItem as ComboBoxKiller).Id < 0)
        //        {
        //            MessageBox.Show("(cmbNIR_Mentor.SelectedItem as ComboBoxKiller).Id < 0");
        //            return;
        //        }

        //        NIRS_Viewer.config.NIRS_DataSet.works.AddworksRow(
        //            (cmbNIR_Student.SelectedItem as ComboBoxKiller).Id,
        //            rtbxStudentTheme.Text,
        //            rtbxStudentBackLog.Text,
        //            (cmbNIR_Mentor.SelectedItem as ComboBoxKiller).Id
        //            );
        //        bindWorks.Save();

        //        DialogResult result = MessageBox.Show("Научная работа добавлена. Очистить поля?", "Добавление", MessageBoxButtons.YesNo);
        //        if (result == DialogResult.Yes)
        //        {
        //            cmbNIR_Student.SelectedIndex = 0;
        //            cmbNIR_Mentor.SelectedIndex = 0;
        //            rtbxStudentTheme.Text = "";
        //            rtbxStudentBackLog.Text = "";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Logs.WriteLine(ex.ToString());
        //    }
        //}



        //private void ckbMoney_CheckedChanged(object sender, EventArgs e)
        //{
        //    txtStudentGrant.Text = "";
        //    txtStudentGrant.Enabled = ckbMoney.Checked;
        //}

       
        
        //private void tabPageStudent_Enter(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        ComboBoxKiller.FillComboBox(dataViewFaculty, cmbStudentFaculty);
        //    }
        //    catch (Exception ex)
        //    {
        //        Logs.WriteLine(ex.ToString());
        //    }
        //}

        //private void cmbStudentFaculty_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        cmbStudentDivision.Enabled = true;
        //        ComboBoxKiller.FillComboBoxWithCmp(dataViewAddedDivision, cmbStudentDivision, 2, 1, (cmbStudentFaculty.SelectedItem as ComboBoxKiller).Id);
        //    }
        //    catch (Exception ex)
        //    {
        //        Logs.WriteLine(ex.ToString());
        //    }
        //}

        //private void cmbStudentDivision_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        cmbStudentSpetialize.Enabled = true;
        //        ComboBoxKiller.FillComboBoxWithCmp(dataViewAddedSpec, cmbStudentSpetialize, 2, 1, (cmbStudentDivision.SelectedItem as ComboBoxKiller).Id);
        //    }
        //    catch (Exception ex)
        //    {
        //        Logs.WriteLine(ex.ToString());
        //    }
        //}

        //private void cmbStudentSpetialize_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        cmbStudentGroup.Enabled = true;
        //        ComboBoxKiller.FillComboBoxWithCmp(dataViewAddedGroup, cmbStudentGroup, 2, 1, (cmbStudentSpetialize.SelectedItem as ComboBoxKiller).Id);
        //    }
        //    catch (Exception ex)
        //    {
        //        Logs.WriteLine(ex.ToString());
        //    }
        //}

        //private void tabPageNIR_Enter(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        ComboBoxKiller.FillComboBox_MentorStudent(dataViewAddedMentor, cmbNIR_Mentor);
        //        ComboBoxKiller.FillComboBox_MentorStudent(dataViewAddedStudent, cmbNIR_Student);
        //    }
        //    catch (Exception ex)
        //    {
        //        Logs.WriteLine(ex.ToString());
        //    }
        //}

        //private void tabPageMentor_Enter(object sender, EventArgs e)
        //{
        //    //ComboBoxKiller.FillComboBox(dataViewAddedDivision, cmbMentorDivision);
        //}

    }

    //class ComboBoxKiller
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public override string ToString()
    //    {
    //        return Name;
    //    }

    //    public static void FillComboBox(DataGridView dtvw, ComboBox cb)
    //    {
    //        cb.Items.Clear();
    //        for (int i = (dtvw.Rows.Count - 1); i >= 0; i--)
    //        {
    //            ComboBoxKiller iam = new ComboBoxKiller();
    //            iam.Id = (int)dtvw.Rows[i].Cells[0].Value;
    //            iam.Name = dtvw.Rows[i].Cells[2].Value.ToString();
    //            cb.Items.Add(iam);
    //        }
    //    }

    //    public static void FillComboBox_MentorStudent(DataGridView dtvw, ComboBox cb)
    //    {
    //        cb.Items.Clear();
    //        for (int i = dtvw.Rows.Count - 1; i >= 0; i--)
    //        {
    //            ComboBoxKiller iam = new ComboBoxKiller();
    //            iam.Id = (int)dtvw.Rows[i].Cells[0].Value;
    //            iam.Name = dtvw.Rows[i].Cells[1].Value.ToString() + " " +
    //                dtvw.Rows[i].Cells[2].Value.ToString() + " " +
    //                dtvw.Rows[i].Cells[3].Value.ToString();
    //            cb.Items.Add(iam);
    //        }
    //    }

    //    public static void FillComboBoxWithCmp(DataGridView dtvw, ComboBox cb, int col_indx, int thatCmp_indx, int idCmp)
    //    {
    //        cb.Items.Clear();
    //        for (int i = dtvw.Rows.Count - 1; i >= 0; i--)
    //        {
    //            if ((int)dtvw.Rows[i].Cells[thatCmp_indx].Value == idCmp)
    //            {
    //                ComboBoxKiller iam = new ComboBoxKiller();
    //                iam.Id = (int)dtvw.Rows[i].Cells[0].Value;
    //                iam.Name = dtvw.Rows[i].Cells[col_indx].Value.ToString();
    //                cb.Items.Add(iam);
    //            }
    //        }
    //    }
    //}
}
