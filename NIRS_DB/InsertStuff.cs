using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NIRS_DB
{
    public static class InsertStuff
    {
        public static void InsertFaculty(string Name, string FullName)
        {
            DBConnection.Request(string.Format("INSERT INTO `{0}` VALUES( null, \"{1}\", \"{2}\" );", "faculty", Name, FullName));
        }

        public static void InsertDivision(int FacId, string Name, string FullName)
        {
            DBConnection.Request(string.Format("INSERT INTO `{0}` VALUES(null, {1}, '{2}', '{3}');", "division", FacId, Name, FullName));
        }
      
        public static void InsertSpecialize(int DivisionId, string Code, string Name)
        {
            DBConnection.Request(
                string.Format(
                    "INSERT INTO `{0}` " +
                    "VALUES (null, {1}, \"{2}\", \"{3}\");",
                    "spec",
                    DivisionId, Code, Name)
                );
        }

        public static void InsertGroup(int SpecId, string Code)
        {
            DBConnection.Request(string.Format("INSERT INTO `{0}` VALUES(null, {1}, '{2}');", "group", SpecId, Code));
        }


        public static void InsertMentor(string Name, string Surname, string FatherName, 
            string Work, string AcademicRank, string Degree, int DivisionId)
        {
            DBConnection.Request(
                string.Format(
                    "INSERT INTO `{0}`" +
                    "VALUES(null, \"{1}\", \"{2}\", \"{3}\", \"{4}\", \"{5}\", \"{6}\", {7});",
                    "mentor",
                    Name, Surname, FatherName, Work, AcademicRank, Degree, DivisionId)
                );
        }
        public static void InsertScienceWork(int StudentId, string Name, string Description, int MentorId)
        {
            DBConnection.Request(
                string.Format(
                    "INSERT INTO `{0}` " +
                    "VALUES (null, {1}, \"{2}\", \"{3}\", {4});",
                    "works",
                    StudentId, Name, Description, MentorId)
                );
        }
        public static void InsertStudent(string Name, string Surname, string FatherName, int GroupId, DateTime BirthDate, string Study, string Grant)
        {
            DBConnection.Request(
                string.Format(
                    "INSERT INTO `{0}` " +
                    "VALUES (null, \"{1}\", \"{2}\", \"{3}\", \"{4}\", \"{5}\", \"{6}\", \"{7}\");",
                    "student",
                    Name, Surname, FatherName, GroupId, BirthDate.Year.ToString() + "-" + BirthDate.Month.ToString() + "-" + BirthDate.Day.ToString(), Study, Grant)
                );
        }
    }
}
