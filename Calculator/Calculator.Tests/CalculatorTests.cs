namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, -2, -3)]
        [InlineData(1, -2, -1)]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, 1)]
        [InlineData(0, -1, -1)]
        public void Add_Tests(int a, int b, int expected)
        {
            int sum = Calculator.Core.Calculator.Add(a, b);
            Assert.Equal(expected, sum);
        }

        [Fact]
        public void Add_BasseCase()
        {
            int sum = Calculator.Core.Calculator.Add(1, 2);
            Assert.Equal(3, sum);
        }

        [Fact]
        public void Add_Negatives()
        {
            int sum = Calculator.Core.Calculator.Add(-1, -2);
            Assert.Equal(-3, sum);
        }

        [Fact]
        public void Add_PositiveAndNegative()
        {
            int sum = Calculator.Core.Calculator.Add(1, -2);
            Assert.Equal(-1, sum);
        }

        [Fact]
        public void Add_ShouldThrowException()
        {
            //int sum = Calculator.Core.Calculator.Add(int.MaxValue, 1);
            Assert.Throws<System.OverflowException>(() => Calculator.Core.Calculator.Add(int.MaxValue, 1));
        }

        [Fact]
        public void Subtract_BaseCase()
        {
            int difference = Calculator.Core.Calculator.Subtract(7, 3);
            Assert.Equal(4, difference);
        }

        [Fact]
        public void Multiply_BaseCase()
        {
            int product = Calculator.Core.Calculator.Multiply(2, 4);
            Assert.Equal(8, product);
        }

        [Fact]
        public void Divide_BaseCase()
        {
            double result = Calculator.Core.Calculator.Divide(12, 2);
            Assert.Equal(6.0, result, 1);
        }

        [Fact]
        public void Divide_ShouldThrowException()
        {
            Assert.Throws<System.ArgumentException>(() => Calculator.Core.Calculator.Divide(2 , 0));
        }
    }
}