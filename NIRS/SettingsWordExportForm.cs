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
        public static DataTable ShowMe { get; set; }

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

                WordTable wt = doc.NewTable(timesRegular, Color.Black, ShowMe.Rows.Count + 2, ShowMe.Columns.Count, 0);
                foreach (WordCell rc in wt.Cells) rc.SetBorders(Color.Black, 1, true, true, true, true);
                wt.SetContentAlignment(ContentAlignment.TopCenter);
                wt.SetFont(timesBigBold);
                wt.Rows[0][0].ColSpan = ShowMe.Columns.Count;
                wt.Rows[0][0].WriteControlWord(Encode("Сводная таблица"));
                wt.SetFont(timesBold);

                for (int i = 0; i < ShowMe.Columns.Count; i++)
                {
                    wt.Rows[1][i].WriteControlWord(Encode(ShowMe.Columns[i].Caption));
                }

                wt.SetFont(timesRegular);
                for (int row = 0; row < ShowMe.Rows.Count; row++)
                {
                    for (int col = 0; col < ShowMe.Columns.Count; col++)
                    {
                        string temp = Encode(ShowMe.Rows[row].ItemArray[col].ToString());
                        wt.Rows[row + 2][col].WriteControlWord(temp);
                    }
                }
            
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
            return (res != "") ? res.Remove(0, 1) : " "; // first '\' added in WriteControlWord
        }
    }
}
