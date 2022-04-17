using System;
namespace cv07
{
    public class Rectangle : Object2D
    { 
        private double side1;
        private double side2;
            
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public override double Area()
        {
            return side1 * side2;
        }

        public override string ToString()
        {
            return string.Format("Rectangle area: {0}", Area());
        }
    }
}
