using System;
using System.Collections.Generic;
using System.Text;

namespace cv06
{
    internal class Block : Object3D
    {
        private double side1;
        private double side2;
        private double side3;
        public Block(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        public override double CountSurface()
        {
            return 2 * (side1 * side2 + side2 * side3 + side1 * side3);
        }
        public override double CountVolume()
        {
            return side1 * side2 * side3;
        }

        public override void Draw()
        {
            Console.WriteLine("Rectangle side1={0}, side2={1}, side3={2}", side1, side2, side3);
        }
    }
}
