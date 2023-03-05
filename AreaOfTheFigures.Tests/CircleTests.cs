using AreaOftheFigures.Figures;

namespace AreaOfTheFigures.Tests
{
    public class CircleTests
    {
        [Fact]
        public void Radius_12_GetSquare_452_4()
        {
            Circle circle = new Circle(12);
            double result = circle.GetSquare();
            double expected = 452.4;
            Assert.Equal(expected, result);
        }
    }
}