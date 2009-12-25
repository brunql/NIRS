using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NIRS_DB
{
    class Student
    {
        string surname;
        string secondname;
        //...
        void Save();
        
    }

    class DB_Criteria
    {
        string surname;
        string secondname;
        //...
    }

    interface IDB_Connector
    {
        // Если не получилось то бросаем какойнить ексепшион
        void Connect();

        // Распарсить все таблицы в сферических студентов в листе.
        List<Student> AllStudents { get; }

        List<Student> Find(DB_Criteria dbc);
    }
}
