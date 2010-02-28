using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using NIRS_DB;
using Gios.Word; // export to word in rtf file format

namespace NIRS
{
    public partial class SettingsWordExportForm : Form
    {
        public SettingsWordExportForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                WordDocument doc = new WordDocument(WordDocumentFormat.A4_Horizontal);

                Font timesBold = new Font("Times", 14, FontStyle.Bold);
                Font timesBigBold = new Font("Times", 18, FontStyle.Bold);
                Font timesRegular = new Font("Times", 14, FontStyle.Regular);
                doc.SetTextAlign(WordTextAlign.Center);
                doc.SetFont(timesBold);
                MySql.Data.MySqlClient.MySqlDataReader reader = DBConnection.ExecuteReader(
                @"SELECT COUNT(*) rows  FROM `student` s
                        JOIN `group` g ON s.group_id = g.id
                        JOIN `spec` spec ON g.spec_id = spec.id
                        JOIN `mentor` m ON s.mentor_id = m.id
                        JOIN `division` d ON spec.div_id = d.id
                        JOIN `faculty` f ON d.fac_id = f.id;"
                );
                reader.Read();
                int rows = reader.GetInt32("rows");
                reader.Close();

                WordTable wt = doc.NewTable(timesRegular, Color.Black, rows + 2, 6, 0);
                foreach (WordCell rc in wt.Cells) rc.SetBorders(Color.Black, 1, true, true, true, true);
                wt.SetContentAlignment(ContentAlignment.TopCenter);
                reader = DBConnection.ExecuteReader(
                        @"SELECT CONCAT(s.surname, ' ', s.name, ' ', s.fathername) `Студент`, 
                        s.born `Дата рождения`,
                        f.name `Факультет`,
                        d.name `Кафедра`,
                        spec.name `Специальность`,
                        g.code `Группа`,
                        CONCAT(m.name, ' ', m.fathername, ' ', m.surname) `Научный руководитель`
                    FROM `student` s
                        JOIN `group` g ON s.group_id = g.id
                        JOIN `spec` spec ON g.spec_id = spec.id
                        JOIN `mentor` m ON s.mentor_id = m.id
                        JOIN `division` d ON spec.div_id = d.id
                        JOIN `faculty` f ON d.fac_id = f.id;"
                        );
                wt.SetFont(timesBigBold);
                wt.Rows[0][0].ColSpan = 6;
                wt.Rows[0][0].WriteControlWord(Encode("Сводная таблица по всем студентам"));
                wt.SetFont(timesBold);
                wt.Rows[1][0].WriteControlWord(Encode("Студент (ФИО)"));
                wt.Rows[1][1].WriteControlWord(Encode("Дата рождения"));
                wt.Rows[1][2].WriteControlWord(Encode("Факультет"));
                wt.Rows[1][3].WriteControlWord(Encode("Кафедра"));
                wt.Rows[1][4].WriteControlWord(Encode("Специальность"));
                wt.Rows[1][5].WriteControlWord(Encode("Группа"));
                wt.Rows[1][6].WriteControlWord(Encode("Научный руководитель"));

                wt.SetFont(timesRegular);
                int row = 2, col = 0;
                while (reader.Read())
                {
                    wt.Rows[row][col++].WriteControlWord(Encode(reader.GetString("Студент")));
                    wt.Rows[row][col++].Write(reader.GetDateTime("Дата рождения").ToShortDateString());
                    wt.Rows[row][col++].WriteControlWord(Encode(reader.GetString("Факультет")));
                    wt.Rows[row][col++].WriteControlWord(Encode(reader.GetString("Кафедра")));
                    wt.Rows[row][col++].WriteControlWord(Encode(reader.GetString("Специальность")));
                    wt.Rows[row][col++].WriteControlWord(Encode(reader.GetString("Группа")));
                    wt.Rows[row][col++].WriteControlWord(Encode(reader.GetString("Научный руководитель")));
                    col = 0;
                    row++;
                }
                reader.Close();
                wt.SaveToDocument(14500, 0);
                doc.FooterStart();
                doc.SetTextAlign(WordTextAlign.Center);
                doc.SetFont(new Font("Verdana", 8, FontStyle.Regular));
                doc.Write("Copyright © 2010 by NIRS Project, KubSTU Dev Team");
                doc.FooterEnd();

                string pathToFile = txtSaveFileName.Text;
                
                try
                {
                    doc.SaveToFile(pathToFile);
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Не удается записать в указанный файл");
                    return;
                }

                if (checkBoxOpenFileAfterExport.Checked)
                    System.Diagnostics.Process.Start(pathToFile);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetFileName_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtSaveFileName.Text = saveFileDialog.FileName;
            }
        }


        static string Encode(string s)
        {
            // TODO: try to rewrite it on StringBuilder mb this will work faster
            string res = "";
            foreach (char c in s.ToCharArray())
            {
                // \u1071u - \uN - this is unicode char num N, alternate for pure ansi have char 'u'
                res += @"\u" + ((int)c) + "u";
            }
            return res.Remove(0, 1); // first '\' added in WriteControlWord
        }
    }
}
