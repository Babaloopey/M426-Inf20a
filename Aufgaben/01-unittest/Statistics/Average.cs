using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Average
    {
        public double Mean(List<int> numbers)
        {
            if(numbers.Count == 0)
            {
                throw new ArgumentException("Eine leere Liste wurde gesendet");
            }

            int sum = 0;
            double mean = 0.0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            mean = (double)sum / numbers.Count;
            return mean;
        }

        public double Median(List<int> numbers)
        {
            if(numbers.Count == 0)
            {
                throw new ArgumentException("Eine leere Liste wurde gesendet");
            }
            numbers.Sort();
            if (isGerade(numbers.Count))
            {
                double numberOne = numbers[getMittlereZahl(numbers.Count) + 1];
                double numberTwo = numbers[getMittlereZahl(numbers.Count)];
                return getAverage(numberOne, numberTwo);
            }
            else
            {
                return numbers[getMittlereZahl(numbers.Count)];
            }
            return 0;
        }

        public bool isGerade(int number)
        {
            return (number % 2) == 0;
        }

        public int getMittlereZahl(int number)
        {
            return (int)Math.Ceiling((double)number / (double)2) - 1;
        }

        public double getAverage(double a, double b)
        {
            return (a + b) / 2;
        }
    }
}
