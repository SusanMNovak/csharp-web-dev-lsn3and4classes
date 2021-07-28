using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student me = new Student();

            me.Name = "Susan";
            me.StudentId = 101;
            me.NumberOfCredits = 1;
            me.Gpa = 4.0;

            Console.WriteLine($"{me.Name} ({me.StudentId})");
            Console.WriteLine($"Credits: {me.NumberOfCredits}, GPA: {me.Gpa}");

            // Generate a new Course
            Course math = new Course();
            math.Id = 202;
            math.Name = "Discrete Structures";
            math.Length = 17;
            math.NumCredits = 4.0;
            math.Roster = new List<Student>();

        }
    }
}