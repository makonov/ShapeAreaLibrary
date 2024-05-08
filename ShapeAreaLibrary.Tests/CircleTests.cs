using FluentAssertions;
using ShapeAreaLibrary.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaLibrary.Tests
{
    public class CircleTests
    {
        [Fact]
        public void GetArea_ReturnsCorrectArea()
        {
            // Arrange
            double radius = 3;
            Circle circle = new Circle(radius);

            // Act
            double area = circle.GetArea();

            // Assert
            area.Should().BeApproximately(28.274, 0.001);
        }
    }
}
