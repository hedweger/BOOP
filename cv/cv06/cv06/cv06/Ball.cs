using System;
using System.Collections.Generic;
using System.Text;

namespace cv06
{
    internal class Ball : Object3D
    {
        private double radius;
        public Ball(double radius)
        {
            this.radius = radius;
        }
        public override double CountSurface()
        {
            return 4 * Math.PI * radius * radius;
        }
        public override double CountVolume()
        {
            return (4 * Math.PI * radius * radius * radius) * 3;
        }
        public override void Draw()
        {
            Console.WriteLine("Ball radius={0}", radius);
        }
    }
}
