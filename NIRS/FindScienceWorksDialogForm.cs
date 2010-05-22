using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using NIRS_DB;

namespace NIRS
{
    public partial class FindScienceWorksDialogForm : Form
    {
        public FindScienceWorksDialogForm()
        {
            try
            {
                InitializeComponent();
                Result = null;
            }
            catch (Exception ex)
            {
                Logs.WriteLine(ex.ToString());
            }
        }

        public static DataTable Result { get; set; }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            try
            {
                DataView t = new DataView();
                Result = new DataTable();
                Result.Load(
                        DBConnection.ExecuteReader(
                        string.Format(
                        @"SELECT CONCAT(s.name,' ',s.fathername, ' ', s.surname) `Студент`,
                        f.name `Факультет`,
                        g.code `Группа`,
                        CONCAT(m.name,' ',m.fathername, ' ', m.surname) `Руководитель`,
                        w.name `Тема научной работы`,
                        w.`desc` `Научный задел`
                    FROM  `works` w
                        JOIN `student` s ON w.student_id = s.id
                        JOIN `mentor` m ON w.mentor_id = m.id
                        JOIN `group` g ON s.group_id = g.id
                        JOIN `spec` spec ON g.spec_id = spec.id
                        JOIN `division` d ON spec.div_id = d.id
                        JOIN `faculty` f ON d.fac_id = f.id
                    WHERE
                        f.name LIKE '%{0}%' AND
                        g.code LIKE '%{1}%' AND
                        CONCAT(s.name,' ',s.fathername, ' ', s.surname) LIKE '%{2}%' AND
                        CONCAT(m.name,' ',m.fathername, ' ', m.surname) LIKE '%{3}%' AND
                        w.name LIKE '%{4}%' AND
                        w.`desc` LIKE '%{5}%';",
                                txtFaculty.Text.Replace('\'', ' '),
                                txtGroup.Text.Replace('\'', ' '),
                                txtStudent.Text.Replace('\'', ' '),
                                txtMentor.Text.Replace('\'', ' '),
                                txtTheme.Text.Replace('\'', ' '),
                                txtDesc.Text.Replace('\'', ' '))
                        )
                     );
                this.Close();
            }
            catch (Exception ex)
            {
                Logs.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Result = null;
            this.Close();
        }
    }
}
