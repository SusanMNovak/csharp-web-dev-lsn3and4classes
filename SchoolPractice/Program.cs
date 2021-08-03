using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student susan = new Student("Susan", 104, 4, 4.0);
            Console.WriteLine(susan);
            susan.AddGrade(3, 3.8);
            Console.WriteLine(susan);
            susan.AddGrade(4, 4.0);
            Console.WriteLine(susan);
            susan.AddGrade(5, 4.0);
            Console.WriteLine(susan);
            susan.AddGrade(4, 4.0);
            Console.WriteLine(susan);
            susan.AddGrade(5, 4.0);
            Console.WriteLine(susan);


        }
    }
}
