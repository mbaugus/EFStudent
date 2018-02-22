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
        static void StudentAssignment()
        {
            DBContextFile db = new DBContextFile();
            //Student[] students
            int totalStudents = db.Students.Count();
            Student[] students = db.Students.ToArray();
            double averageSat = students.Average(s => s.SAT);
            decimal averageGPA = students.Average(s => s.GPA);
            Student[] studentsGraduated = db.Students
                .Where(s => s.GradYear < DateTime.Today.Year)
                .OrderBy(s => s.GradYear)
                .ToArray();

            Student[] studentsWithHigherSat = students.Where(s => s.SAT > averageSat).OrderByDescending(s => s.SAT).ToArray();

            WriteLine($"Total Students: {totalStudents}");
            foreach (var s in students)
            {
                WriteLine($"Id: {s.Id}, Name: {s.Name}, Major: { s.Major}, GradYr: {s.GradYear}, Honors: {s.GradWithHonors}, Donor: {s.AlumniDoner}, SAT: {s.SAT}, GPA {s.GPA}");
            }

            WriteLine($"\nGraduated Students");
            foreach (var s in studentsGraduated)
            {
                WriteLine($"Name: {s.Name} {s.GradYear}");
            }
            WriteLine($"\nAverage Student GPA: {averageGPA}");
            WriteLine($"Average SAT: {averageSat}");
            WriteLine($"\nStudents with 'Greater than Average SAT ({averageSat})");
            foreach (var s in studentsWithHigherSat)
            {
                WriteLine($"Name: {s.Name}, SAT: {s.SAT}");
            }
        }

        static void TestAssignment()
        {
            DBContextFile db = new DBContextFile();
            Test[] tests = db.Tests.ToArray();
        }
        static void Main(string[] args)
        {
            StudentAssignment();
            TestAssignment();
        }
    }
}
