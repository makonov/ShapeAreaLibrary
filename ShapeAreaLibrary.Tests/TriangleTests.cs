using ShapeAreaLibrary.Shapes;
using FluentAssertions;

namespace ShapeAreaLibrary.Tests
{
    public class TriangleTests
    {
        [Fact]
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
            area.Should().Be(6);
        }

        [Fact]
        public void IsRight_ReturnsTrue()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool isRight = triangle.IsRight();

            // Assert
            isRight.Should().BeTrue();
        }

        [Fact]
        public void IsRight_ReturnsFalse()
        {
            // Arrange
            double sideA = 2;
            double sideB = 3;
            double sideC = 7;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool isRight = triangle.IsRight();

            // Assert
            isRight.Should().BeFalse();
        }
    }
}