
//using System;
//using System.Collections.Generic;

//namespace NIRS_DB.Structs
//{
	
	
//    public class Student : ActiveRecord
//    {
//        public int Id { get; private set; }
//        public string Name { get; set; }
//        public string Surname { get; set; }
//        public string FatherName { get; set; }
//        //public int Age
//        //{
//        //    get { return 0; }
//        //    set { }
//        //}
//        public DateTime Born { get; set; }
//        public int Year { get; set; } // what is this?

//        public List<ScienceWork> ScienceWorks { get; set; }
//        public Mentor Mentor { get; set; }
//        public Division Division { get; set; }
//        public Group Group { get; set; }		
		
//        public Student()
//        {
//            tableName = "student";
//        }

//        public override ActiveRecord Find(DBCriteria crit)
//        {
//            throw new NotImplementedException();
//        }

//        public override void Delete(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public override void Save()
//        {
//            string query = "";
//            if (Id == 0)
//            {
//                query = string.Format(
//                    "INSERT INTO `{0}` " +
//                    "VALUES (null, {1}, \"{2}\", \"{3}\");",
//                    tableName,
//                    Name, Surname, FatherName, Group.Id,, Code, Name);

//                query = "INSERT INTO `" + tableName + "` VALUES(null,\"" + name + "\",\"" + surname + 
//                    "\",\"" + fatherName + "\"," + group_id + "," + mentor_id + ",\"" + born.Year + "-" + born.Month + "-" + born.Day + "\");"; 
//            }
//            else
//            {
//                query = "UPDATE `" + tableName + "` `name`=\"" + name + "\", `surname`=\"" + surname + "\", `fathername`=\"" + fatherName + 
//                    "\", `group_id`=" + group_id + ",`mentor_id`=" + mentor_id + ",`born`=\"" + born.ToString() + "\"" +
//                    " WHERE `id`=" + id + ";";
//            }

//            MakeRequest(query);
//        }
//    }
//}
