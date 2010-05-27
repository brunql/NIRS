using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NIRS
{
    public partial class AddStudent : Form
    {
        private NIRS_Viewer.bind bindFaculty;
        private NIRS_Viewer.bind bindDivision;
        private NIRS_Viewer.bind bindSpec;
        private NIRS_Viewer.bind bindGroup;
        private NIRS_Viewer.bind bindMentor;
        private NIRS_Viewer.bind bindStudent;

        public AddStudent()
        {
            try
            {
                InitializeComponent();
                this.bindStudent = new NIRS_Viewer.bind();
                this.bindStudent.DataMember = "student";
                this.bindStudent.Position = 0;

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

                this.dataViewAddedStudent.DataSource = this.bindStudent;
                DataGridInitializer.InitStudent(this.dataViewAddedStudent);

                tabControlStudent.MouseWheel += new MouseEventHandler(tabControlStudent_MouseWheel);
            }
            catch (Exception ex)
            {
                Logs.WriteLine(ex.ToString());
            }
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            //ComboBoxKiller.FillComboBox(dataViewFaculty, cmbStudentFaculty);
            cmbStudentFaculty.DataSource = bindFaculty;
            cmbStudentFaculty.DisplayMember = "name";
            cmbStudentDivision.DataSource = bindDivision;
            cmbStudentDivision.DisplayMember = "name";
            //cmbStudentDivision.DataSource = bindDivision;
            //cmbStudentDivision.DisplayMember = "name";
            //cmbStudentDivision.DataSource = bindDivision;
            //cmbStudentDivision.DisplayMember = "name";
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
            try
            {
                DateTime birthdate = new DateTime();
                try
                {
                    birthdate = dateTimePickerStudent.Value; //Convert.ToDateTime(txtStudentBirthdayDate.Text);
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
                    txtStudentName.Text,
                    txtStudentSurname.Text,
                    txtStudentFathername.Text,
                    (cmbStudentGroup.SelectedItem as ComboBoxKiller).Id,
                    birthdate,
                    cmbStudentBudget.Text,
                    ((txtStudentGrant.Text == "") ? "Нет" : txtStudentGrant.Text),
                    txtStudentEmail.Text,
                    txtStudentPhone.Text,
                    "gpa",
                    9,
                    "science theme",
                    "address home",
                    "science works",
                    0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
                    "awards for scientific work",
                    true, true, true
                    );
                bindStudent.Save();

                DialogResult result = MessageBox.Show("Студент добавлен. Очистить поля?", "Добавление", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    txtStudentSurname.Text = "";
                    txtStudentFathername.Text = "";
                    txtStudentName.Text = "";
                    txtStudentGrant.Text = "";
                    txtStudentEmail.Text = "";
                    txtStudentPhone.Text = "";
                    //txtStudentPatents.Text = "";
                    //txtStudentProgramCount.Text = "";
                    //txtStudentPublicationCount.Text = "";
                    //txtStudentAsset.Text = "";

                    // TODO
                }
            }
            catch (Exception ex)
            {
                Logs.WriteLine(ex.ToString());
            }
        }

        private void ckbMoney_CheckedChanged(object sender, EventArgs e)
        {
            txtStudentGrant.Text = "";
            txtStudentGrant.Enabled = ckbMoney.Checked;
        }


        private void cmbStudentFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbStudentDivision.Enabled = true;
                //ComboBoxKiller.FillComboBoxWithCmp(dataViewAddedDivision, cmbStudentDivision, 2, 1, (cmbStudentFaculty.SelectedItem as ComboBoxKiller).Id);
            }
            catch (Exception ex)
            {
                Logs.WriteLine(ex.ToString());
            }
        }

        private void cmbStudentDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbStudentSpetialize.Enabled = true;
                //ComboBoxKiller.FillComboBoxWithCmp(dataViewAddedSpec, cmbStudentSpetialize, 2, 1, (cmbStudentDivision.SelectedItem as ComboBoxKiller).Id);
            }
            catch (Exception ex)
            {
                Logs.WriteLine(ex.ToString());
            }
        }

        private void cmbStudentSpetialize_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbStudentGroup.Enabled = true;
                //ComboBoxKiller.FillComboBoxWithCmp(dataViewAddedGroup, cmbStudentGroup, 2, 1, (cmbStudentSpetialize.SelectedItem as ComboBoxKiller).Id);
            }
            catch (Exception ex)
            {
                Logs.WriteLine(ex.ToString());
            }
        }

        void tabControlStudent_MouseWheel(object sender, MouseEventArgs e)
        {
            // пристрелите меня, где я не прав?

            int scroll = tableLayoutPanel.VerticalScroll.Value;
            if (e.Delta > 0)
            {
                scroll -= 20;
                txtStudentFathername.BackColor = Color.Blue;
            }
            else
            {
                scroll += 20;
                txtStudentFathername.BackColor = Color.Red;
            }

            if (scroll > tableLayoutPanel.VerticalScroll.Maximum)
            {
                scroll = tableLayoutPanel.VerticalScroll.Maximum;
            }
            else if (scroll < tableLayoutPanel.VerticalScroll.Minimum)
            {
                scroll = tableLayoutPanel.VerticalScroll.Minimum;
            }
            tableLayoutPanel.VerticalScroll.Value = scroll;
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
