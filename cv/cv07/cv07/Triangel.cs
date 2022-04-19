using System;
namespace cv07
{
    public class Triangle : Object2D
    {
        private double height;
        private double side;

        public Triangle(double side, double height)
        {
            this.side = side;
            this.height = height;
        }
        public override double Area()
        {
            double s = (side * height) / 2;
            return s;
        }
        public override string ToString()
        {
            return String.Format("Triangle area: " + Area());
        }
    }
}
