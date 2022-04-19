using System;

namespace cv07
{
    public class Circle : Object2D
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            return 2 * Math.PI * radius * radius;
        }
        public override string ToString()
        {
            return String.Format("Circle area: " + Area());
        }
    }
}
