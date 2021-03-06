﻿using System;
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
    public partial class FindStudentDialogForm : Form
    {
        public FindStudentDialogForm()
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
                
                int? group_first_nums = null;
                if (cmbKurs.SelectedItem != null)
                {
                    group_first_nums = DateTime.Now.Year;
                    group_first_nums -= Convert.ToInt32(cmbKurs.SelectedItem);
                    if (DateTime.Now.Month >= 07) group_first_nums++;
                    group_first_nums %= 100;
                }
                string query = string.Format(
                        @"SELECT CONCAT(s.name,' ',s.fathername, ' ', s.surname) `Студент`, s.born `Дата рождения`,
                        f.name `Факультет`,
                        d.name `Кафедра`,
                        spec.name `Специальность`,
                        g.code `Группа`,
                        s.study `Форма обучения`,
                        s.`grant`  `Стипендия`
                    FROM `student` s
                        JOIN `group` g ON s.group_id = g.id
                        JOIN `spec` spec ON g.spec_id = spec.id
                        JOIN `division` d ON spec.div_id = d.id
                        JOIN `faculty` f ON d.fac_id = f.id
                    WHERE s.name LIKE '%{0}%' AND
                        s.fathername LIKE '%{1}%' AND
                        s.surname LIKE '%{2}%' AND
                        f.name LIKE '%{3}%' AND
                        d.name LIKE '%{4}%' AND
                        spec.name LIKE '%{5}%' AND
                        g.code LIKE '%{6}%' ",
                              txtStudentName.Text.Replace('\'', ' '),
                              txtStudentFathername.Text.Replace('\'', ' '),
                              txtStudentSurname.Text.Replace('\'', ' '),
                              txtFaculty.Text.Replace('\'', ' '),
                              txtDivision.Text.Replace('\'', ' '),
                              txtSpec.Text.Replace('\'', ' '),
                              txtGroup.Text.Replace('\'', ' '));
                if (group_first_nums != null)
                {
                    query +=  string.Format(" AND g.code LIKE '{0}%'", ((int)group_first_nums).ToString("00"));
                }
                query += ";";
                Result.Load( DBConnection.ExecuteReader(query) );
                this.Close();
            }
            catch(Exception ex)
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