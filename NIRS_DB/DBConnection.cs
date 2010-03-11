#region Usings
using System;
using MySql;
using MySql.Data;
using MySql.Data.Types;
using MySql.Data.MySqlClient;
using System.Threading;
#endregion


namespace NIRS_DB
{
	public class DBConnection
	{
		#region Vars
		/// <summary>
		/// Singleton 
		/// </summary>
		private static DBConnection _dbc;
		
		private MySqlConnection _conn;
		
		
		#endregion
		
		#region Private Functions
		private DBConnection(MySqlConnection conn)
		{
            this._conn = conn;
		}
		
		private void Check()
		{
            
			if (_dbc == null)
			{
				throw new Exception("Not connected to database");	
			}
		}
		#endregion
		
		#region Public Functions

        public static DBSettings InstalledSettings { get; private set; }

		public static void Connection(DBSettings settings)
		{
			string connection_string = "Server=" + settings.host + ";Port=" + settings.port +";Database=" + settings.database +
				";Uid=" + settings.user + ";Pwd=" + settings.pwd +";";
			MySqlConnection conn = new MySqlConnection(connection_string);
			try
			{
				conn.Open();
                _dbc = new DBConnection(conn);
                InstalledSettings = settings;
			}
			catch (MySqlException ex)
			{
                Console.WriteLine(ex.ToString());
                throw;
			}
		}
		
		public static void Request(string query)
		{
            MySqlCommand command = new MySqlCommand(query, _dbc._conn);
            command.CommandText = query;
            command.ExecuteNonQuery();
		}

        public static MySqlDataReader ExecuteReader(string query)
        {
            MySqlCommand command = new MySqlCommand(query, _dbc._conn);
            command.CommandText = query;
            return command.ExecuteReader();
        }

		#endregion
	}
}
