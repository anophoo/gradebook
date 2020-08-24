using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    class Book
    {
        private List<double> grades;
        private string name;

        public Book(string name)
        {
            this.grades = new List<double>();
            this.name = name;
        }

        public void ShowStatistics()
        {
            if (grades == null) return;

            var lowestGrade = grades.Min();
            var highestGrade = grades.Max();
            var averageGrade = grades.Sum() / grades.Count();

            Console.WriteLine($"The lowest grade is {lowestGrade:N2}");
            Console.WriteLine($"The highest grade is {highestGrade:N2}");
            Console.WriteLine($"The average grade is {averageGrade:N2}");
        }

        public void AddGrade(double grade)
        {
            this.grades.Add(grade);
        }
    }
}