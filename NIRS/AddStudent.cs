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
        private NIRS_Viewer.bind bindDivisionStudent;
        private NIRS_Viewer.bind bindDivisionMentor;
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

                this.bindDivisionStudent = new NIRS_Viewer.bind();
                this.bindDivisionStudent.DataMember = "division";
                this.bindDivisionStudent.Position = 0;

                this.bindDivisionMentor = new NIRS_Viewer.bind();
                this.bindDivisionMentor.DataMember = "division";
                this.bindDivisionMentor.Position = 0;

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
                MessageBox.Show(ex.Message);
            }
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            try
            {
                cmbStudentFaculty.DataSource = bindFaculty;
                cmbStudentFaculty.DisplayMember = "name";
                //cmbStudentFaculty.ValueMember = "id"; why it doesn't work as i want?

                cmbMentorDivision.DataSource = bindDivisionMentor;
                cmbMentorDivision.DisplayMember = "name";

                bindDivisionStudent.Filter = "fac_id = -1";
                cmbStudentDivision.DataSource = bindDivisionStudent;
                cmbStudentDivision.DisplayMember = "name";
                cmbStudentDivision.Enabled = false;

                bindSpec.Filter = "div_id = -1";
                cmbStudentSpetialize.DataSource = bindSpec;
                cmbStudentSpetialize.DisplayMember = "name";
                cmbStudentSpetialize.Enabled = false;

                bindGroup.Filter = "spec_id = -1";
                cmbStudentGroup.DataSource = bindGroup;
                cmbStudentGroup.DisplayMember = "code";
                cmbStudentGroup.Enabled = false;

                bindMentor.Filter = "div_id = -1";
                cmbMentorFIO.DataSource = bindMentor;
                cmbMentorFIO.DisplayMember = "surname";
                cmbMentorFIO.Enabled = false;
            }
            catch (Exception ex)
            {
                Logs.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
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
            {   // mb it isn't good way
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

                if ((int)(cmbStudentGroup.SelectedItem as DataRowView)["id"] < 0)
                {
                    MessageBox.Show("cmbStudentGroup['id'] < 0");
                    return;
                }

                NIRS_Viewer.config.NIRS_DataSet.student.AddstudentRow(
                    txtStudentName.Text,
                    txtStudentSurname.Text,
                    txtStudentFathername.Text,
                    (int)(cmbStudentGroup.SelectedItem as DataRowView)["id"],
                    birthdate,
                    cmbStudentBudget.Text,
                    ((txtStudentGrant.Text == "") ? "Нет" : txtStudentGrant.Text),
                    txtStudentEmail.Text,
                    txtStudentPhone.Text,
                    txtGPA.Text,
                    Convert.ToUInt32(txtNIR_Years.Text),
                    txtScienceTheme.Text,
                    txtHomeAddress.Text,
                    txtScienceWorks.Text,
                    Convert.ToUInt32(txtPublicationsCount.Text),
                    Convert.ToUInt32(txtArticlesCount.Text),
                    Convert.ToUInt32(txtIntellictualAndIndustrialPropertyCount.Text),
                    Convert.ToUInt32(txtPatentsCount.Text),
                    Convert.ToUInt32(txtPositiveSolutionOnInventionsCount.Text),
                    Convert.ToUInt32(txtRequestsOnInventionsCount.Text),
                    txtAwardsOnScientificWorks.Text,
                    ckbContiniueStuding.Checked,
                    ckbWorkInScience.Checked,
                    ckbWorkInDivision.Checked,
                    Convert.ToUInt32(txtCertificateOnPCSoftCount.Text),
                    Convert.ToUInt32(txtRequestsOnPcSoftCount.Text),
                    txtImplementationInIndustry.Text,
                    txtImplementationInStudy.Text
                    );
                bindStudent.Save();

                DialogResult result = MessageBox.Show("Студент добавлен. Очистить поля?", "Добавление", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    txtStudentName.Text = "";
                    txtStudentSurname.Text = "";
                    txtStudentFathername.Text = "";
                    txtStudentGrant.Text = "";
                    txtStudentEmail.Text = "";
                    txtStudentPhone.Text = "";
                    txtGPA.Text = "";
                    txtNIR_Years.Text = "";
                    txtScienceTheme.Text = "";
                    txtHomeAddress.Text = "";
                    txtScienceWorks.Text = "";
                    txtPublicationsCount.Text = "";
                    txtArticlesCount.Text = "";
                    txtIntellictualAndIndustrialPropertyCount.Text = "";
                    txtPatentsCount.Text = "";
                    txtPositiveSolutionOnInventionsCount.Text = "";
                    txtRequestsOnInventionsCount.Text = "";
                    txtAwardsOnScientificWorks.Text = "";
                    ckbContiniueStuding.Checked = false;
                    ckbWorkInScience.Checked = false;
                    ckbWorkInDivision.Checked = false;
                    txtCertificateOnPCSoftCount.Text = "";
                    txtRequestsOnPcSoftCount.Text = "";
                    txtImplementationInIndustry.Text = "";
                    txtImplementationInStudy.Text = "";
                }
            }
            catch (Exception ex)
            {
                Logs.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void ckbMoney_CheckedChanged(object sender, EventArgs e)
        {
            txtStudentGrant.Text = "";
            txtStudentGrant.Enabled = ckbMoney.Checked;
        }

        private void cmbStudentFaculty_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                cmbStudentSpetialize.Enabled = false;
                cmbStudentGroup.Enabled = false;

                int fac_id = -1;
                object o = cmbStudentFaculty.SelectedItem;
                if (o != null)
                {
                    fac_id = (int)((DataRowView)o)["id"];
                    cmbStudentDivision.Enabled = true;
                }
                else
                {
                    cmbStudentDivision.Enabled = false;
                }
                bindDivisionStudent.Filter = "fac_id = " + fac_id.ToString();
            }
            catch (Exception ex)
            {
                Logs.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbStudentDivision_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                cmbStudentGroup.Enabled = false;

                int div_id = -1;
                object o = cmbStudentDivision.SelectedItem;
                if (o != null)
                {
                    cmbStudentSpetialize.Enabled = true;
                    div_id = (int)((DataRowView)o)["id"];
                }
                else
                {
                    cmbStudentSpetialize.Enabled = false;
                }
                bindSpec.Filter = "div_id = " + div_id.ToString();
            }
            catch (Exception ex)
            {
                Logs.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message + "\nОшибка деления на огурец, переустановите вселенную и перезагрузитесь. frm brunql ;)");
            }
        }

        private void cmbStudentSpetialize_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int spec_id = -1;
                object o = cmbStudentSpetialize.SelectedItem;
                if (o != null)
                {
                    cmbStudentGroup.Enabled = true;
                    spec_id = (int)((DataRowView)o)["id"];
                }
                else
                {
                    cmbStudentGroup.Enabled = false;
                }

                bindGroup.Filter = "spec_id = " + spec_id.ToString();
            }
            catch (Exception ex)
            {
                Logs.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        void tabControlStudent_MouseWheel(object sender, MouseEventArgs e)
        {
            // TODO: пристрелите меня, где я не прав?
            //if ((new Random()).Next(2) == 1) return;
            //int scroll = tableLayoutPanel.VerticalScroll.Value;
            //if (e.Delta > 0)
            //{
            //    scroll -= 50;
            //    txtStudentFathername.BackColor = Color.Blue;
            //}
            //else if (e.Delta < 0)
            //{
            //    scroll += 50;
            //    txtStudentFathername.BackColor = Color.Red;
            //}

            //if (scroll > tableLayoutPanel.VerticalScroll.Maximum)
            //{
            //    scroll = tableLayoutPanel.VerticalScroll.Maximum;
            //}
            //else if (scroll < tableLayoutPanel.VerticalScroll.Minimum)
            //{
            //    scroll = tableLayoutPanel.VerticalScroll.Minimum;
            //}
            //tableLayoutPanel.VerticalScroll.Value = scroll;
        }

        private void cmbMentorDivision_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int div_id = -1;
                object o = cmbMentorDivision.SelectedItem;
                if (o != null)
                {
                    cmbMentorFIO.Enabled = true;
                    div_id = (int)((DataRowView)o)["id"];
                }
                else
                {
                    cmbMentorFIO.Enabled = false;
                }

                bindMentor.Filter = "div_id = " + div_id.ToString();
            }
            catch (Exception ex)
            {
                Logs.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }
    }

    // Hey! I said: "I will remove it, as soon as possible...", and i did it!
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
