using System;
using System.Collections.Generic;
using System.Text;

namespace cv06
{
    internal class Triangle : Object2D
    {
        private double height;
        private double side;

        public Triangle(double side, double height)
        {
            this.side = side;
            this.height = height;
        }
        public override double CountArea()
        {
            double s = (side * height) / 2;
            return s;
        }
        public override void Draw()
        {
            Console.WriteLine("Rectangle height={0}, side={1}", height, side);
        }
    }
}
