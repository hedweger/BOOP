using System;
using System.Collections.Generic;
using System.Text;

namespace cv06
{
    internal class Ellipse : Object2D
    {
        private double radius1 ;
        private double radius2 ;
        public Ellipse(double radius1, double radius2)
        {
            this.radius1 = radius1;
            this.radius2 = radius2;
        }
        public override double CountArea()
        {
            return Math.PI * radius1 * radius2;
        }
        public override void Draw()
        {
            Console.WriteLine("Circle radius1={0}, radius2={1}", radius1, radius2);
        }
    }
}
