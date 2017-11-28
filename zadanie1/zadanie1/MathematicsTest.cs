using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace zadanie1
{
    public class MathematicsTest
    {
        [Theory]
        [InlineData(10, 20, 30)]
        [
        InlineData(-10, 10, 0),
        InlineData(30, 40, 70),
        InlineData(-20, -10, -30),
        InlineData(-0d, 0d, -0d)]

        public void TheoryExample(double x, double y, double expected)
        {
            //arrange
            var math = new Mathematic();
            //act
            var result = math.Add(x, y);
            //assert
            Assert.Equal(expected, result);

        }
        [Fact]
        public void Add_returns_sum2_of_given_values()
        {
            //arrange
            var math = new Mathematic();
            //act
            var result = math.Add(10, -20);
            //assert
            Assert.Equal(-10, result);

        }
        [Fact]
        public void Add_returns_subtraction_of_given_values()
        {
            //arrange
            var math = new Mathematic();
            //act
            var result = math.Substract(90, 40);
            //assert
            Assert.Equal(50, result);

        }
        [Fact]
        public void Add_returns_subtraction2_of_given_values()
        {
            //arrange
            var math = new Mathematic();
            //act
            var result = math.Substract(10, 20);
            //assert
            Assert.Equal(-10, result);

        }
        [Fact]
        public void Add_returns_multi_of_given_values()
        {
            //arrange
            var math = new Mathematic();
            //act
            var result = math.Multiplication(10, 20);
            //assert
            Assert.Equal(200, result);

        }
        [Fact]
        public void Add_returns_multi2_of_given_values()
        {
            //arrange
            var math = new Mathematic();
            //act
            var result = math.Multiplication(-5, 20);
            //assert
            Assert.Equal(-100, result);
        }
        [Fact]
        public void Add_returns_devision1_of_given_values()
        {
            //arrange
            var math = new Mathematic();
            //act
            var result = math.devision(100, 20);
            //assert
            Assert.Equal(5, result);
        }
        [Fact]
        public void Add_returns_devision2_of_given_values()
        {
            //arrange
            var math = new Mathematic();
            //act
            var result = math.devision(100, 0);

            Assert.True(double.IsInfinity(result));
            //assert
            //Assert.Equal(5, result);
        }
    }
}
