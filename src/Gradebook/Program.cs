using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Divesh's Gradebook");
            book.AddGrades(99.12);
            book.AddGrades(96.23);
            book.AddGrades(99.23);
            var result = book.GetStats();
            Console.WriteLine($"Average of all Grades are {result.Average:N1}");
            Console.WriteLine($"Highest Grade is {result.High}");
            Console.WriteLine($"Lowest Grade is {result.Low}");
            Book book1 = new Book("Kamala's Gradebook");
            book1.AddGrades(99.99);
            book1.AddGrades(98.99);
            book1.AddGrades(98.12);
            var result2 = book1.GetStats();
            Console.WriteLine($"Average of all Grades are {result2.Average:N1}");
            Console.WriteLine($"Highest Grade is {result2.High}");
            Console.WriteLine($"Lowest Grade is {result2.Low}");
        }
    }
}
