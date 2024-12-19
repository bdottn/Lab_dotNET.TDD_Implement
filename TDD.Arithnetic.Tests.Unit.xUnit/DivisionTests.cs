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

        [Fact]
        public void Divide_WhenDivisorIsZero_ThrowsDivideByZeroException_1()
        {
            // Arrange
            int dividend = 1;
            int divisor = 0;

            // Act
            Exception e = Record.Exception(() => Division.Divide(dividend, divisor));

            // Assert
            Assert.IsType<DivideByZeroException>(e);
        }

        [Fact]
        public void Divide_WhenDivisorIsZero_ThrowsDivideByZeroException_2()
        {
            // Arrange
            int dividend = 1;
            int divisor = 0;

            // Act
            Action act = () => Division.Divide(dividend, divisor);

            // Assert
            Assert.Throws<DivideByZeroException>(act);
        }

        [Theory]
        [InlineData(int.MaxValue, int.MinValue, -0.999999999534)]
        [InlineData(-int.MaxValue, int.MinValue, 0.999999999534)]
        [InlineData(int.MinValue, int.MaxValue, -1.000000000466)]
        [InlineData(int.MinValue, -int.MaxValue, 1.000000000466)]
        public void Divide_ExtremeInput_CorrectCalculation(int dividend, int divisor, decimal expectedQuotient)
        {
            // Arrange

            // Act
            decimal actQuotient = Division.Divide(dividend, divisor);

            // Assert
            Assert.Equal(expectedQuotient, actQuotient, 12);
        }
    }
}