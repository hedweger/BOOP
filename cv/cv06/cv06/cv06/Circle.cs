using System;
using System.Collections.Generic;
using System.Text;

namespace cv06
{
    internal class Circle : Object2D
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double CountArea()
        {
            return Math.PI * radius * radius;
        }
        public override void Draw()
        {
            Console.WriteLine("Circle radius={0}", radius);
        }
    }
}
