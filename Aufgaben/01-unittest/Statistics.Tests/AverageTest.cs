using System;
using System.Collections.Generic;
using Xunit;

namespace Statistics.Tests
{
    public class AverageTest
    {
        [Fact]
        public void TestMeanOfTwoNumbers()
        {
            List<int> numbers = new List<int> { 2, 3 };
            double expected = 2.5;
            Average average = new Average();

            double actual = average.Mean(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TeastMeanOfFiveNumbers()
        {
            // arrange 
            List<int> numbers = new List<int> { 2, 3, 4, 5, 6 };
            double expected = 4;
            Average average = new Average();

            // act
            double actual = average.Mean(numbers);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMeanOfNoNumbers()
        {
            // arrange 
            List<int> numbers = new List<int> {};
            Average average = new Average();

            // act && assert
            Assert.Throws<ArgumentException>(() => average.Mean(numbers));

        }

        [Fact]
        public void TestMedianForOddNumberOfElements()
        {
            // arrange 
            List<int> numbers = new List<int> { 2, 3, 4, 5, 6 };
            double expected = 4;
            Average average = new Average();

            // act
            double actual = average.Median(numbers);

            // assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void TestMedianForEvenNumberOfElements()
        {
            // arrange 
            List<int> numbers = new List<int> { 4,5,7,6,3,2 };
            double expected = 4.5;
            Average average = new Average();

            // act
            double actual = average.Median(numbers);

            // assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void TestMedianForNoElements()
        {
            // arrange 
            List<int> numbers = new List<int> { };
            Average average = new Average();

            // act && assert
            Assert.Throws<ArgumentException>(() => average.Median(numbers));
        }
    }
}
