using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    public class Book
    {
        private List<double> grades;
        private string name;

        public Book(string name)
        {
            this.grades = new List<double>();
            this.name = name;
        }

        public Statistics GetStatistics()
        {
            if (grades == null) return null;

            var lowestGrade = grades.Min();
            var highestGrade = grades.Max();
            var averageGrade = grades.Sum() / grades.Count();
            return new Statistics(lowestGrade, highestGrade, averageGrade);
        }

        public void AddGrade(double grade)
        {
            this.grades.Add(grade);
        }
    }
}