/*
 * Created by SharpDevelop.
 * User: Администратор
 * Date: 20.03.2010
 * Time: 21:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace NIRS_Viewer
{
	/// <summary>
	/// Description of config.
	/// </summary>
	public class config
	{
		private static string _connection_string ;
		private static MySqlConnection _connection;
		private static DataSet _nirs_DataSet;
		
		
		public static string NIRS_ConnectionString {get {if(_connection_string==null)
														{ throw new Exception("property didn't initialize. Use \"Initialize\" method"); }
													else
														{return _connection_string;}}
												set{ _connection_string = value;} }
		public static MySqlConnection NIRS_MySqlConnection {get {if(_connection==null)
														{ throw new Exception("property didn't initialize. Use \"Initialize\" method"); }
													else
														{return _connection;}}
												set{ _connection = value;} }
		public static DataSet NIRS_DataSet {get {if(_nirs_DataSet==null)
														{ throw new Exception("property didn't initialize. Use \"Initialize\" method"); }
													else
														{return _nirs_DataSet;}}
												set{ _nirs_DataSet = value;} }
		
		private static MySqlCommandBuilder command_builder_division;
		private static MySqlCommandBuilder command_builder_faculty;
		private static MySqlCommandBuilder command_builder_group;
		private static MySqlCommandBuilder command_builder_mentor;
		private static MySqlCommandBuilder command_builder_spec;
		private static MySqlCommandBuilder command_builder_student;
		private static MySqlCommandBuilder command_builder_works;
		
		private static MySqlDataAdapter adapter_division;
		private static MySqlDataAdapter adapter_faculty;
		private static MySqlDataAdapter adapter_group;
		private static MySqlDataAdapter adapter_mentor;
		private static MySqlDataAdapter adapter_spec;
		private static MySqlDataAdapter adapter_student;
		private static MySqlDataAdapter adapter_works;
		
		private static string select_division_string = "SELECT id, fac_id, name, fullname FROM division";
		private static string select_faculty_string = "SELECT id, name, fullname FROM faculty";
		private static string select_group_string = "SELECT id, spec_id, code FROM `group`";
		private static string select_mentor_string = "SELECT id, name, surname, fathername, work, acrank, degree,div_id FROM mentor";
		private static string select_spec_string = "SELECT id, div_id, code, name FROM spec";
		private static string select_student_string = @"SELECT id, name, surname, fathername, group_id, born, study, `grant` FROM student";
		private static string select_works_string = "SELECT id, student_id, name, `desc`, mentor_id FROM works";
		
		public static bool IsInitialize {get; private set;}
		
		// it need for one DataSet, MySqlConnection, NIRS_ConnectionString
		public static void Initialize(string conn)
		{
			// this block check on initialized and possibility get a NIRS_MySqlConnection
			if(IsInitialize)
			{
				throw new Exception("I am initialized already");
			}
			try
			{
				NIRS_MySqlConnection = new MySqlConnection(conn);
				NIRS_MySqlConnection.Open();
//				if(!NIRS_MySqlConnection.Ping())
//				{
//					throw new Exception();
//				}
			}
			catch
			{
				NIRS_MySqlConnection = null;
				throw new Exception("bad NIRS_MySqlConnection string");
			}
			NIRS_ConnectionString = conn;
			
			NIRS_DataSet = new DataSet();
			NIRS_DataSet.Locale = System.Globalization.CultureInfo.InvariantCulture;
			
//			DataTable variable_table;
			
			adapter_faculty = new MySqlDataAdapter(select_faculty_string, NIRS_MySqlConnection);
			adapter_faculty.Fill(NIRS_DataSet, "faculty");
			command_builder_faculty = new MySqlCommandBuilder(adapter_faculty);

            // Just testing
            adapter_faculty.InsertCommand = new global::MySql.Data.MySqlClient.MySqlCommand();
            adapter_faculty.InsertCommand.Connection = NIRS_MySqlConnection;
            adapter_faculty.InsertCommand.CommandText = "INSERT INTO `nirs`.`faculty` (`name`, `fullname`) VALUES (@name, @fullname)";
            adapter_faculty.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            MySql.Data.MySqlClient.MySqlParameter param = new global::MySql.Data.MySqlClient.MySqlParameter();
            param.ParameterName = "@name";
            param.DbType = global::System.Data.DbType.String;
            param.MySqlDbType = global::MySql.Data.MySqlClient.MySqlDbType.VarChar;
            param.IsNullable = true;
            param.SourceColumn = "name";
            adapter_faculty.InsertCommand.Parameters.Add(param);
            param = new global::MySql.Data.MySqlClient.MySqlParameter();
            param.ParameterName = "@fullname";
            param.DbType = global::System.Data.DbType.String;
            param.MySqlDbType = global::MySql.Data.MySqlClient.MySqlDbType.VarChar;
            param.IsNullable = true;
            param.SourceColumn = "fullname";
            adapter_faculty.InsertCommand.Parameters.Add(param);

//			variable_table = NIRS_DataSet.Tables["faculty"];
			
			adapter_division = new MySqlDataAdapter(select_division_string, NIRS_MySqlConnection);
			adapter_division.Fill(NIRS_DataSet, "division");
			command_builder_division = new MySqlCommandBuilder(adapter_division);
			
			adapter_group = new MySqlDataAdapter(select_group_string, NIRS_MySqlConnection);
			adapter_group.Fill(NIRS_DataSet, "group");
			command_builder_group = new MySqlCommandBuilder(adapter_group);
			
			adapter_mentor = new MySqlDataAdapter(select_mentor_string, NIRS_MySqlConnection);
			adapter_mentor.Fill(NIRS_DataSet, "mentor");
			command_builder_mentor = new MySqlCommandBuilder(adapter_mentor);
			
			adapter_spec = new MySqlDataAdapter(select_spec_string, NIRS_MySqlConnection);
			adapter_spec.Fill(NIRS_DataSet, "spec");
			command_builder_spec = new MySqlCommandBuilder(adapter_spec);
			
			adapter_student = new MySqlDataAdapter(select_student_string, NIRS_MySqlConnection);
			adapter_student.Fill(NIRS_DataSet, "student");
			command_builder_student = new MySqlCommandBuilder(adapter_student);
			
			adapter_works = new MySqlDataAdapter(select_works_string, NIRS_MySqlConnection);
			adapter_works.Fill(NIRS_DataSet, "works");
			command_builder_works = new MySqlCommandBuilder(adapter_works);
            
			
			foreach(DataTable table in NIRS_DataSet.Tables)
			{
				table.Columns[0].ColumnMapping = MappingType.Hidden;
			}
			
			NIRS_MySqlConnection.Close();
		}
		
		public static void Fill(string table_name)
		{
			switch (table_name)
			{
				case("faculty") : adapter_faculty.Fill(NIRS_DataSet, "faculty"); break;
				case("division") : adapter_division.Fill(NIRS_DataSet, "division"); break;
				case("group") : adapter_group.Fill(NIRS_DataSet, "group"); break;
				case("mentor") : adapter_mentor.Fill(NIRS_DataSet, "mentor"); break;
				case("spec") : adapter_spec.Fill(NIRS_DataSet, "spec"); break;
				case("student") : adapter_student.Fill(NIRS_DataSet, "student"); break;
				case("works") : adapter_works.Fill(NIRS_DataSet, "works"); break;
			}
		}
		
		public static void Update(string table_name)
		{
			switch (table_name)
			{
				case("faculty") : adapter_faculty.Update(NIRS_DataSet.Tables["faculty"]); break;
				case("division") : adapter_division.Update(NIRS_DataSet, "division"); break;
				case("group") : adapter_group.Update(NIRS_DataSet, "group"); break;
				case("mentor") : adapter_mentor.Update(NIRS_DataSet, "mentor"); break;
				case("spec") : adapter_spec.Update(NIRS_DataSet, "spec"); break;
				case("student") : adapter_student.Update(NIRS_DataSet, "student"); break;
				case("works") : adapter_works.Update(NIRS_DataSet, "works"); break;
			}
		}

        public static int InsertFaculty(string name, string fullname)
        {
            if ((name == null))
            {
                throw new global::System.ArgumentNullException("name");
            }
            else
            {
                adapter_faculty.InsertCommand.Parameters[0].Value = ((string)(name));
            }
            if ((fullname == null))
            {
                throw new global::System.ArgumentNullException("fullname");
            }
            else
            {
                adapter_faculty.InsertCommand.Parameters[1].Value = ((string)(fullname));
            }
            global::System.Data.ConnectionState previousConnectionState = adapter_faculty.InsertCommand.Connection.State;
            if (((adapter_faculty.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                adapter_faculty.InsertCommand.Connection.Open();
            }
            try
            {
                int returnValue = adapter_faculty.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    adapter_faculty.InsertCommand.Connection.Close();
                }
            }
        }
	}
}
