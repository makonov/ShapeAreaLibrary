using ShapeAreaLibrary.Shapes;

namespace ShapeAreaTests
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    public class TriangleTests : PageTest
    {
        [Test]
        public void GetArea_ReturnsCorrectArea()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            double area = triangle.GetArea();

            // Assert
            Assert.AreEqual(6, area);
        }
    }
}
