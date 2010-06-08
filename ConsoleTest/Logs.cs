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

        public static void WriteLine(string message)
        {
            Console.WriteLine(DateTime.Now.ToString("[dd.MM.yyyy hh:mm:ss] ") +  message);
        }
    }
}
