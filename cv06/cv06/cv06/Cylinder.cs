using System;
using System.Collections.Generic;
using System.Text;

namespace cv06
{
    internal class Cylinder : Object3D
    {
        private double height;
        private double radius;

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }
        public override double CountSurface()
        {
            return 2 * Math.PI * radius * (radius + height);
        }
        public override double CountVolume()
        {
            return Math.PI * radius * radius * height;
        }
        public override void Draw()
        {
            Console.WriteLine("Rectangle height={0}, radius={1}", height, radius);
        }
    }
}

