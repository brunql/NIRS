
using System;
using System.Collections.Generic;

namespace NIRS_DB.Structs
{
	
	
	public class Mentor : ActiveRecord
	{
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public string Work { get; set; }
        public string Degree { get; set; }
        public string AcademicRank { get; set; }
        public int DivisionId { get; set; }
		
        private Division div;

        public Division Division
        {
            get { return div; }
            set 
            {
                div = value;
                DivisionId = value.Id;
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
            if (Id == 0)
            {
                query = string.Format(
                    "INSERT INTO `{0}`" +
                    "VALUES(null, \"{1}\", \"{2}\", \"{3}\", \"{4}\", \"{5}\", \"{6}\", {7});",
                    tableName, 
                    Name, Surname, FatherName, Work, AcademicRank, Degree, DivisionId);
            }
            else
            {
                throw new NotImplementedException();
                //query = "UPDATE `" + tableName + "` `name`=\"" + name + "\", `surname`=\"" + surname + "\", `fathername`=\"" + fartherName + 
                //    "\",  `work`=\"" + work + "\", `arank`=\"" + academic_rank + "\", `degree`=\"" + degree + "\", `div_id`="+div_id + 					
                //    " WHERE `id`=" + id + ";";
            }

            MakeRequest(query);
        }
        
	}
}
