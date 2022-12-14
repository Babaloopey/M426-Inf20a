using System.Threading;
using Xunit;

namespace Refactoring.Tests;

public class FibonacciTest
{
    [Fact]
    public void TestFirstFibonacciNumberIsOne()
    {
        // TODO: write test
    }

    [Fact]
    public void TestBigFibonacciNumber()
    {
        // Arrange
        int n = 45;
        int expected = 1134903170;

        // Act
        int actual = Fibonacci.Fib(n);

        // Assert
        Assert.Equal(expected, actual);
    }
}