using System.Collections.Generic;
using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("ABC Book");

            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit:");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }

                try
                {
                    book.AddGrade(double.Parse(input));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("***");
                }
            }

            Console.WriteLine($"lowest grade is {book.GetStatistics().LowestGrade}");
            Console.WriteLine($"highest grade is {book.GetStatistics().LowestGrade}");
            Console.WriteLine($"average grade is {book.GetStatistics().AverageGrade}");
        }
    }

}