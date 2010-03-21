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
    public partial class FindMentorDialogForm : Form
    {
        public FindMentorDialogForm()
        {
            InitializeComponent();
            Result = null;
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
                        @"SELECT CONCAT(m.name,' ',m.fathername, ' ', m.surname) `Научный руководитель`,
                        f.name `Факультет`,
                        d.name `Кафедра`,
                        m.work `Работа`,
                        m.acrank `Учёное звание`,
                        m.degree `Учёная степень`
                    FROM `mentor` m
                        JOIN `division` d ON m.div_id = d.id
                        JOIN `faculty` f ON d.fac_id = f.id
                    WHERE m.name LIKE '%{0}%' AND
                        m.fathername LIKE '%{1}%' AND
                        m.surname LIKE '%{2}%' AND
                        f.name LIKE '%{3}%' AND
                        d.name LIKE '%{4}%' AND
                        m.work LIKE '%{5}%' AND
                        m.acrank LIKE '%{6}%' AND
                        m.degree LIKE '%{7}%';",
                              txtMentorName.Text.Replace('\'',' '),
                              txtMentorFathername.Text.Replace('\'', ' '),
                              txtMentortSurname.Text.Replace('\'', ' '),
                              txtFaculty.Text.Replace('\'', ' '),
                              txtDivision.Text.Replace('\'', ' '),
                              txtWork.Text.Replace('\'', ' '),
                              txtAcademRank.Text.Replace('\'', ' '),
                              txtAcademDegree.Text.Replace('\'', ' '))
                        )
                     );
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Result = null;
            this.Close();
        }
            //buttonFind_Click(null, null);

    }
}