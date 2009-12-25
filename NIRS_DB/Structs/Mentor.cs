
using System;
using System.Collections.Generic;

namespace NIRS_DB.Structs
{
	
	
	public class Mentor : ActiveRecord
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

        private string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        private string fartherName;

        public string FatherName
        {
            get { return fartherName; }
            set { fartherName = value; }
        }

        private string work;

        public string Work
        {
            get { return work; }
            set { work = value; }
        }

        private string degree;
        public string Degree
        {
            get { return degree; }
            set { degree = value; }
        }

        private string academic_rank;
        public string AcademicRank
        {
            get { return academic_rank; }
            set { academic_rank = value; }
        }

        private int div_id;

		private Division div;

        public Division Division
        {
            get { return div; }
            set 
            {
                div = value;
                div_id = value.Id;
            }
        }

		private List<Student> students;
				
		public Mentor()
		{
			tableName = "mentor";
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
                query = "INSERT INTO `" + tableName + "` VALUES(null,\"" + name + "\",\"" + surname + 
					"\",\"" + fartherName + "\",\"" + work + "\",\"" + academic_rank + "\",\"" + degree + "\"," + div_id +
						");";
            }
            else
            {
                query = "UPDATE `" + tableName + "` `name`=\"" + name + "\", `surname`=\"" + surname + "\", `fathername`=\"" + fartherName + 
					"\",  `work`=\"" + work + "\", `arank`=\"" + academic_rank + "\", `degree`=\"" + degree + "\", `div_id`="+div_id + 					
                    " WHERE `id`=" + id + ";";
            }

            MakeRequest(query);
        }
        
	}
}
