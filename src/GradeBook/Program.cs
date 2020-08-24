using System.Collections.Generic;
using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("ABC Book");
            book.AddGrade(43.2);
            book.AddGrade(12);
            book.AddGrade(9);
        }
    }

}