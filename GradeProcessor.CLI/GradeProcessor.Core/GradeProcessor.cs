namespace GradeProcessor.Core
{
    public class GradeProcessor
    {
        public static double CalculateAverage(List<int> grades)
        {
            if (grades.Count == 0)
            {
                throw new ArgumentException("Empty List");
            }
            return grades.Average();
        }

        public static int CalculateMaximum(List<int> grades)
        {
            if (grades.Count == 0)
            {
                throw new ArgumentException("Empty List");
            }
            return grades.Max();
        }

        public static double CalculateMedian(List<int> grades)
        {
            if (grades.Count == 0)
            {
                throw new ArgumentException("Empty List");
            }

            var sortedGrades = grades.OrderBy(g => g).ToList();
            int count = sortedGrades.Count;
            if (count % 2 == 1)
            {
                return sortedGrades[count / 2]; // Odd count, return middle value
            }
            else
            {
                return (sortedGrades[(count / 2) - 1] + sortedGrades[count / 2]) / 2.0; // Even count, return average of two middle values
            }
        }
    }
}
