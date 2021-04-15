using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Rafa"); 
            book.AddGrade(80.39);
            book.AddGrade(35.45);
            book.AddGrade(83.73);
            book.AddGrade(38.82);
            book.AddGrade(28.10);
            book.AddGrade(19.20);

            var stats = book.GetStatistics(); 

            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The higest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average}");
        }
    }
}
