using System;

namespace cv06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GrObject[] objects = new GrObject[]
            {
                new Ball(2),
                new Block(2,3,4),
                new Cylinder(4,2),
                new Circle(2),
                new Ellipse(2,3),
                new Pyramid(2,5,2),
                new Rectangle(2,4),
                new Triangle(2,5),
            };
            

            foreach (var item in objects)
            {
                double area = 0;
                double surface = 0;
                double volume = 0;
                item.Draw();

                if(item is Object2D)
                {
                    area = ((Object2D)item).CountArea();
                    Console.WriteLine("Area = {0}", area);
                    Console.WriteLine("");
                }
                else if (item is Object3D)
                {
                    surface = ((Object3D)item).CountSurface();
                    volume = ((Object3D)item).CountVolume();
                    Console.WriteLine("Surface = {0}, Volume = {1}", surface, volume);
                    Console.WriteLine("");
                }
                 
            }
        }
    }
}
