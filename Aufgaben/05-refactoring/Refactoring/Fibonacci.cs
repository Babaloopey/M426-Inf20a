namespace Refactoring;

public class Fibonacci
{
    public static int Fib(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Fibonacci undefined for negative numbers");
        }
        if (n == 0 || n == 1)
        {
            return n;
        }
        return Fib(n - 2) + Fib(n - 1);
    }
}