using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

using Gios.Word;
using NIRS_DB;
using MySql.Data.MySqlClient;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string connection_string =
                "server=localhost;port=3306;uid=nirs;pwd=;database=nirs;";
            MySqlConnection conn = new MySqlConnection(connection_string);
            conn.Open();

            Console.WriteLine("sucks");

//            DBConnection.ConnectionWithDefaultSettings();

//            string pathToFile = @"C:\Users\Миха\Documents\test.doc";

//            WordDocument doc = new WordDocument(WordDocumentFormat.A4_Horizontal);

//            Font timesBold = new Font("Times", 14, FontStyle.Bold);
//            Font timesRegular = new Font("Times", 14, FontStyle.Regular);
//            doc.SetTextAlign(WordTextAlign.Center);
//            doc.SetFont(timesBold);
//            MySql.Data.MySqlClient.MySqlDataReader reader = DBConnection.ExecuteReader(
//            @"SELECT COUNT(*) rows  FROM `student` s
//                        JOIN `group` g ON s.group_id = g.id
//                        JOIN `spec` spec ON g.spec_id = spec.id
//                        JOIN `mentor` m ON s.mentor_id = m.id
//                        JOIN `division` d ON spec.div_id = d.id
//                        JOIN `faculty` f ON d.fac_id = f.id;"
//            );
//            reader.Read();
//            int rows = reader.GetInt32("rows");
//            reader.Close();

//            WordTable wt = doc.NewTable(timesRegular, Color.Black, rows + 1, 6, 0);
//            foreach (WordCell rc in wt.Cells) rc.SetBorders(Color.Black, 1, true, true, true, true);
//            wt.SetContentAlignment(ContentAlignment.TopCenter);
//            reader = DBConnection.ExecuteReader(
//                    @"SELECT CONCAT(s.surname, ' ', s.name, ' ', s.fathername) `Студент`, 
//                        s.born `Дата рождения`,
//                        f.name `Факультет`,
//                        d.name `Кафедра`,
//                        spec.name `Специальность`,
//                        g.code `Группа`,
//                        CONCAT(m.name, ' ', m.fathername, ' ', m.surname) `Научный руководитель`
//                    FROM `student` s
//                        JOIN `group` g ON s.group_id = g.id
//                        JOIN `spec` spec ON g.spec_id = spec.id
//                        JOIN `mentor` m ON s.mentor_id = m.id
//                        JOIN `division` d ON spec.div_id = d.id
//                        JOIN `faculty` f ON d.fac_id = f.id;"
//                    );
//            wt.SetFont(timesBold);
//            wt.Rows[0][0].WriteControlWord(Encode("Студент (ФИО)"));
//            wt.Rows[0][1].WriteControlWord(Encode("Дата рождения"));
//            wt.Rows[0][2].WriteControlWord(Encode("Факультет"));
//            wt.Rows[0][3].WriteControlWord(Encode("Кафедра"));
//            wt.Rows[0][4].WriteControlWord(Encode("Специальность"));
//            wt.Rows[0][5].WriteControlWord(Encode("Группа"));
//            wt.Rows[0][6].WriteControlWord(Encode("Научный руководитель"));

//            wt.SetFont(timesRegular);
//            int row = 1, col = 0;
//            while (reader.Read())
//            {
//                wt.Rows[row][col++].WriteControlWord(Encode(reader.GetString("Студент")));
//                wt.Rows[row][col++].WriteControlWord(Encode(reader.GetString("Дата рождения")));
//                wt.Rows[row][col++].WriteControlWord(Encode(reader.GetString("Факультет")));
//                wt.Rows[row][col++].WriteControlWord(Encode(reader.GetString("Кафедра")));
//                wt.Rows[row][col++].WriteControlWord(Encode(reader.GetString("Специальность")));
//                wt.Rows[row][col++].WriteControlWord(Encode(reader.GetString("Группа")));
//                wt.Rows[row][col++].WriteControlWord(Encode(reader.GetString("Научный руководитель")));
//                col = 0;
//                row++;
//            }
//            reader.Close();
//            wt.SaveToDocument(13000, 0);
//            doc.SaveToFile(pathToFile);
//            System.Diagnostics.Process.Start(pathToFile);
//            Console.WriteLine("Done! " + ((int)'\\').ToString() + ((int)(@"'"[0])).ToString());
//           // Console.ReadLine();
        }


        static string Encode(string s)
        {
            // TODO: try to rewrite it on StringBuilder mb this will work faster
            string res = "";
            foreach (char c in s.ToCharArray())
            {
                // \u1071u - \uN - this is unicode char num N, alternate for pure ansi have char 'u'
                res += @"\u" + ((int)c) + "u" ;
            }
            return res.Remove(0,1); // first '\' added in WriteControlWord
        }

        //static char[] hexDigits = {
        //                              '0', '1', '2', '3', '4', '5', '6', '7',
        //                              '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};

        //internal static string ToHexString(byte Byte)
        //{
        //    int b = Byte;
        //    return  hexDigits[b & 0xF].ToString() + hexDigits[b >> 4].ToString();
        //}

        //internal static string Encode(string s)
        //{
        //    UnicodeEncoding ue = new UnicodeEncoding();
        //    s = s.Replace(@"\", @"\\");
        //    System.Text.StringBuilder sb = new System.Text.StringBuilder();
        //    foreach (char c in s.ToCharArray())
        //    {
        //        if ((c >= 48 && c <= 122) || c == '\n' || c == ' ') sb.Append(c);
        //        else
        //        {
        //            if (c == 'Ђ')
        //                sb.Append(@"\'80");
        //            else
        //            {
        //                string tmp = @"\u" + ((int)c);
        //                sb.Append(tmp);
        //            }
        //        }
        //    }
        //    return sb.ToString().Replace("\r\n", @"\par").Replace("\n", @"\par ");

        //}

    }
}
