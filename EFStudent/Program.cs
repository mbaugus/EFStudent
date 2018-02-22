using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace EFStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            DBContextFile db = new DBContextFile();
            //Student[] students
            int totalStudents = db.Students.Count();
            Student[] students = db.Students.ToArray();
            Student[] studentsGraduated = db.Students
                .Where(s => s.GradYear < DateTime.Today.Year)
                .OrderBy(s => s.GradYear)
                .ToArray();

            WriteLine($"Total Students: {totalStudents}");
            foreach (var s in students)
            {
                WriteLine($"Name: {s.Name}");
            }

            WriteLine($"\nGraduated Students");
            foreach(var s in studentsGraduated)
            {
                WriteLine($"Name: {s.Name} {s.GradYear}");
            }

            // Task 1
            //    print number of students in the db on consol
            //Tsk 2
            //    get a list of all the students in no special order
            //    print all the names on the console
            //task 3 
            //    get list of all the student that graduated

            //*** advanced
            //Add new properties called SAT(int) and GPA(decimal)
            //Update all the rows
            //
        }
    }
}
