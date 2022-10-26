using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAddTwoToTwoIsFour()
        {
            // Arrange
            int a = 2;
            int b = 2;
            int expected = 4;
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSubtractFourFromSixIsTwo()
        {
            // Given
            int a = 6;
            int b = 4;
            int expected = 2;
            Calculator calculator = new Calculator();

            // When
            int actual = calculator.Subtract(a, b);

            // Then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMultiplyThreeWithFourIsTwelve()
        {
            // arrange
            int a = 3;
            int b = 4;
            int expected = 12;
            Calculator calculator = new Calculator();

            // act
            int actual = calculator.Multiply(a, b);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
