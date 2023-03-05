using AreaOftheFigures.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfTheFigures.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void Sides_4_4_5_Return_Square7_8()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double expected = 6.0;
            double result = triangle.GetSquare();
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(6, 8, 10)]
        public void SendValidSides_Return_True(double firstSide, double secondSide, double thirdSide)
        {
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);
            Assert.True(triangle.IsRectangular());
        }

        [Theory]
        [InlineData(12, 1, 4)]
        [InlineData(3, 5, 5)]
        public void SendValidSides_Return_False(double firstSide, double secondSide, double thirdSide)
        {
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);
            Assert.False(triangle.IsRectangular());
        }
    }
}
