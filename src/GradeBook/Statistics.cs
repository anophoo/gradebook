namespace GradeBook
{
    public class Statistics
    {
        public double LowestGrade;
        public double HighestGrade;
        public double AverageGrade;

        public Statistics(double lowestGrade, double highestGrade, double averageGrade)
        {
            this.LowestGrade = lowestGrade;
            this.HighestGrade = highestGrade;
            this.AverageGrade = averageGrade;
        }
    }
}