
using System;

namespace NIRS_DB
{
	
	
	public class DBSettings
	{
		public string host;
		public string port = "3306";
		public string user;
		public string pwd;
		public string database;

        private static DBSettings defaultSettings = new DBSettings(
                    "localhost",
                    "3306",
                    "nirs",
                    "",
                    "nirs"
                );

        public static DBSettings DefaultSettings { get { return defaultSettings; } }

        public DBSettings(string host,
            string port,
            string user,
            string pwd,
            string database)
        {
            this.host = host;
            this.port = port;
            this.user = user;
            this.pwd = pwd;
            this.database = database;
        }
	}
}
