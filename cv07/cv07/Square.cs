using System;
namespace cv07
{
    public class Square : Object2D
    {
        private double side;
        public Square(double side)
        {
            this.side = side;
        }
        public override double Area()
        {
            return side * side;
        }
        public override string ToString()
        {
            return string.Format("Square area: " + Area());
        }
    }
}
