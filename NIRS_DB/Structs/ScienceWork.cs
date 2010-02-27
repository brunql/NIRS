
using System;

namespace NIRS_DB.Structs
{
	
	
	public class ScienceWork : ActiveRecord
	{
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Student StudentInScience { get; set; }
		
		public ScienceWork()
		{
            tableName = "works";
		}

        public override ActiveRecord Find(DBCriteria crit)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override void Save()
        {
			string query = "";
            if (Id == 0)
            {
                query = string.Format(
                    "INSERT INTO `{0}` " +
                    "VALUES (null, {1}, \"{2}\", \"{3}\");",
                    tableName,
                    StudentInScience.Id, Name, Description);
            }
            else
            {
                throw new NotImplementedException();
                //query = "UPDATE `" + tableName + "` `student_id`=" + student_id + ",`name`=\"" + name 
                //    + "\",`desc`=\"" + description + "\"" + 
                //    " WHERE `id`=" + id + ";";
            }

            MakeRequest(query);
        }

        }

	}
