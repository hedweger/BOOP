using System;
using System.Collections.Generic;
using System.Text;

namespace cv06
{
    internal class Rectangle : Object2D
    {
        private double side1;
        private double side2;
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public override double CountArea()
        {
            return side1 * side2;
        }
        public override void Draw()
        {
            Console.WriteLine("Rectangle side1={0}, side2={1}", side1, side2);
        }
    }
}
