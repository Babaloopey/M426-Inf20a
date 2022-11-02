using Xunit;

namespace FooBarQix.Tests
{
    public class FooBarQixDeterminerTest
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "FooFoo")]
        [InlineData(4, "4")]
        [InlineData(5, "BarBar")]
        [InlineData(6, "Foo")]
        [InlineData(7, "QixQix")]
        [InlineData(8, "8")]
        [InlineData(9, "Foo")]
        [InlineData(10, "Bar")]
        [InlineData(13, "Foo")]
        [InlineData(15, "FooBarBar")]
        [InlineData(21, "FooQix")]
        [InlineData(33, "FooFooFoo")]
        [InlineData(51, "FooBar")]
        [InlineData(53, "BarFoo")]

        public void Test1(int parameter, string expected)
        {
            // arrange
            var determiner = new FooBarQixDeterminer();

            // act
            string actual = determiner.Determine(parameter); 

            // assert
            Assert.Equal(expected, actual);

        }
    }
}