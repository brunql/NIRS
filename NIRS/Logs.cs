using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace NIRS
{
    public class Logs
    {
        // Singlton

        public static Logs logs;

        private StreamWriter sw;

        private Logs()
        {
            try
            {
                if (!Directory.Exists(Environment.CurrentDirectory + @"\logs"))
                {
                    Directory.CreateDirectory(Environment.CurrentDirectory + @"\logs");
                }
                sw = new StreamWriter(Environment.CurrentDirectory + @"\logs\" + DateTime.Now.ToString("yyyy_MM_dd") + ".log", true);
                sw.WriteLine(sw.NewLine + "Log stream opened: " + DateTime.Now.ToShortTimeString());
                sw.Flush();
            }
            catch(Exception ex)
            {
                throw new IOException("Ошибка при инициализации лог файла: " + Environment.CurrentDirectory + @"\logs\" + DateTime.Now.ToString("yyyy_MM_dd") + ".log", ex);
            }
        }

        public static void WriteLine(string message)
        {
            if (logs == null) logs = new Logs();

            logs.sw.WriteLine(DateTime.Now.ToString("[dd.MM.yyyy hh:mm:ss] ") +  message);
            logs.sw.Flush();
        }
    }
}
