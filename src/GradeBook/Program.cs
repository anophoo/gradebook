using System.Collections.Generic;
using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> grades = new List<double>();
            grades.Add(12.1);
            Console.WriteLine(grades[0]);
            if (args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]}!");
            }
        }
    }
}