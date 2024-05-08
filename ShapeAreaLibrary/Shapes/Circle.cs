using ShapeAreaLibrary.Interfaces;

namespace ShapeAreaLibrary.Shapes
{
    public class Circle : IShape
    {
        private double radius;
        public double GetArea() => Math.PI * radius * radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
    }
}
