using System;
using System.Collections.Generic;
using System.Text;

namespace cv06
{
    internal class Pyramid : Object3D
    {
        private double side1;
        private double side2;
        private double height;

        public Pyramid(double side1, double height, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.height = height;
        }
        public override double CountSurface()
        {
            return side1 * height * 2;
        }
        public override double CountVolume()
        {
            return(side1 * side1 * height) / 3;
        }
        public override void Draw()
        {
            Console.WriteLine("Rectangle height={0}, side1={1}, side2={2}", height, side1, side2);
        }
    }
}
