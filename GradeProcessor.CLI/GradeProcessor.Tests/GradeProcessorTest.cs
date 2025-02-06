namespace GradeProcessor.Tests
{
    public class GradeProcessorTests
    {
        [Fact]
        public void CalculateAverage_ShouldReturnCorrectAverage()
        {
            List<int> grades = new List<int> { 80, 90, 100 };
            double result = GradeProcessor.Core.GradeProcessor.CalculateAverage(grades);
            Assert.Equal(90.0, result, 1);
        }

        [Fact]
        public void CalculateAverage_ShouldHandleEmptyList()
        {
            List<int> grades = new List<int> { };
            Assert.Throws<System.ArgumentException>(() => GradeProcessor.Core.GradeProcessor.CalculateAverage(grades));
        }

        [Fact]
        public void CalculateAverage_ShouldHandle100MGradesIn1Sec()
        {
            List<int> grades = Enumerable.Range(1, 100_000_000).ToList();
            DateTime start = DateTime.UtcNow;
            GradeProcessor.Core.GradeProcessor.CalculateAverage(grades);
            DateTime end = DateTime.UtcNow;
            double elapsed = (end - start).TotalMilliseconds;
            Assert.True(elapsed < 200, $"Execution took {elapsed} ms");
        }

        [Fact]
        public void CalculateMaximum_ShouldReturnCorrectMaximum()
        {
            List<int> grades = new List<int> { 70, 85, 92, 100, 60 };
            int result = GradeProcessor.Core.GradeProcessor.CalculateMaximum(grades);
            Assert.Equal(100, result);
        }

        [Fact]
        public void CalculateMedian_ShouldReturnCorrectMedian_ForOddCount()
        {
            List<int> grades = new List<int> { 70, 85, 92 };
            double result = GradeProcessor.Core.GradeProcessor.CalculateMedian(grades);
            Assert.Equal(85.0, result);
        }

        [Fact]
        public void CalculateMedian_ShouldReturnCorrectMedian_ForEvenCount()
        {
            List<int> grades = new List<int> { 70, 85, 90, 100 };
            double result = GradeProcessor.Core.GradeProcessor.CalculateMedian(grades);
            Assert.Equal(87.5, result);
        }
    }
}
