using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeAreaLibrary.Interfaces;

namespace ShapeAreaLibrary.Shapes
{
    public class Triangle : IShape
    {
        private double sideA, sideB, sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public double GetArea()
        {
            double p = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }

        public bool IsRight()
        {
            double max = Math.Max(sideA, Math.Max(sideB, sideC));
            double min = Math.Min(sideA, Math.Min(sideB, sideC));
            double middle = sideA + sideB + sideC - max - min;

            return max * max == min * min + middle * middle;
        }
    }
}
