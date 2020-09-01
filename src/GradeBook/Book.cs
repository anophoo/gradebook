using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    public class Book
    {
        private List<double> grades;
        public string Name;

        public Book(string name)
        {
            this.grades = new List<double>();
            this.Name = name;
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
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new ArgumentException($"The grade {grade} is not valid");
            }
        }
    }
}
