
using System;
using System.Collections.Generic;

namespace NIRS_DB.Structs
{
	
	
	public class Student : ActiveRecord
	{
		private int id;
		
		public int Id
		{
			get { return id; }	
		}
		
		private string name;

		public string Name
		{
			get {return name;}
            set { name = value; }
		}
		
		private string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

		private string fatherName;

        public string FatherName
        {
            get { return fatherName; }
            set { fatherName = value; }
        }

        public int Age
        {
            get { return 0; }
            set { }
        }

        private DateTime born;

        public DateTime Born
        {
            get { return born; }
            set { born = value; }
        }

		private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

		private List<ScienceWork> works;

        public List<ScienceWork> ScienceWorks
        {
            get { return works; }
            set { works = value; }
        }

		private Mentor mentor;

        public Mentor Mentor
        {
            get { return mentor; }
            set
            {
                mentor = value;
                mentor_id = value.Id;
            }
        }

		private int mentor_id;
        public int MentorId
        {
            get { return mentor_id; }
            set { mentor_id = value; }
        }

		private int division_id;
        public int DivisionId
        {
            get { return division_id; }
            set { division_id = value; }
        }
        private Division division;


        public Division Division
        {
            get { return division; }
            set
            {
                division = value;
                division_id = value.Id;
            }
        }


        private int group_id;
        public int GroupId
        {
            get { return group_id; }
            set { group_id = value; }
        }
        private Group group;

        public Group Group
        {
            get { return group; }
            set
            {
                group = value;
                group_id = value.Id;
            }
        }
		
		public Student()
		{
            tableName = "student";
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
					"\",\"" + fatherName + "\"," + group_id + "," + mentor_id + ",\"" + born.Year + "-" + born.Month + "-" + born.Day + "\");"; 
            }
            else
            {
                query = "UPDATE `" + tableName + "` `name`=\"" + name + "\", `surname`=\"" + surname + "\", `fathername`=\"" + fatherName + 
					"\", `group_id`=" + group_id + ",`mentor_id`=" + mentor_id + ",`born`=\"" + born.ToString() + "\"" +
                    " WHERE `id`=" + id + ";";
            }

            MakeRequest(query);
        }
	}
}
