using System;
namespace cv07
{
    public class Ellipse : Object2D
    {
            private double radius1;
        private double radius2;
        public Ellipse(double radius1, double radius2)
        {
            this.radius1 = radius1;
            this.radius2 = radius2;
        }
        public override double Area()
        {
            return Math.PI * radius1 * radius2;
        }
        public override string ToString()
        {
            return String.Format("Ellipse area: " + Area());
        }
    }
}
