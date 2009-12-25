
using System;

namespace NIRS_DB.Structs
{
	
	
	public class ScienceWork : ActiveRecord
	{
		private int id;

        public int Id
        {
            get { return id; }
        }

		private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


		private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

		private int student_id;

		private Student student;

        public Student Student
        {
            get { return student; }
            set
            {
                student = value;
                student_id = value.Id;
            }
        }
		
		public ScienceWork()
		{
			
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
            if (id == 0)
            {
                query = "INSERT INTO `" + tableName + "` VALUES(null," + student_id +"\"" + name + "\",\""+description+"\");";
            }
            else
            {
                query = "UPDATE `" + tableName + "` `student_id`=" + student_id + ",`name`=\"" + name 
					+ "\",`desc`=\"" + description + "\"" + 
                    " WHERE `id`=" + id + ";";
            }

            MakeRequest(query);
        }

        }

	}
