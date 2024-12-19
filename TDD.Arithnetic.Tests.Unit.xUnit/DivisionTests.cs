namespace TDD.Arithnetic.Tests.Unit.xUnit
{
    public class DivisionTests
    {
        [Fact]
        public void Divide_WhenDividendIsThreeDivisorIsOne_ReturnsThree()
        {
            // Arrange
            int dividend = 3;
            int divisor = 1;

            // Act
            decimal quotient = Division.Divide(dividend, divisor);

            // Assert
            Assert.Equal(3, quotient);
        }

        [Fact]
        public void Divide_WhenDividendIsThreeDivisorIsTwo_ReturnsOnePointFive()
        {
            // Arrange
            int dividend = 3;
            int divisor = 2;

            // Act
            decimal quotient = Division.Divide(dividend, divisor);

            // Assert
            Assert.Equal(1.5m, quotient);
        }
    }
}