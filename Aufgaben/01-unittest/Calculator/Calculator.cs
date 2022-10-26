using System;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int summandA, int summandB)
        {
            return summandA + summandB;
        }

        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        public int Multiply(int multiplikator, int multiplikand)
        {
            return multiplikator * multiplikand;
        }

        public int Divide(int dividend, int divisor)
        {
            if(divisor == 0)
            {
                throw new ArgumentException("Teilen durch 0 nicht möglich.");
            }

            return dividend / divisor;
        }
    }
}
