using System;
using System.Linq;

namespace cv07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 3, 5, 7, 9 };
            string[] strings = new string[] { "a", "b", "c" };
            Circle[] circles = new Circle[] { new Circle(2), new Circle(3), new Circle(4) };
            Rectangle[] rectangles = new Rectangle[] { new Rectangle(2, 3), new Rectangle(3, 4), new Rectangle(4, 5) };
            Ellipse[] ellipses = new Ellipse[] { new Ellipse(2, 3), new Ellipse(3, 4)};
            Object2D[] objectfield = new Object2D[] { new Circle(2), new Square(3), new Rectangle(2, 4) };

            Console.WriteLine("Largest int: " + Extremes.Largest(numbers));
            Console.WriteLine("Smallest int: " + Extremes.Smallest(numbers));
            Console.WriteLine("Largest circle: " + Extremes.Largest(circles));
            Console.WriteLine("Smallest circle: " + Extremes.Smallest(circles));

            var fourtoeight = numbers.Where(v => v > 4 && v < 8);
            Console.Write("Filtered: ");
            foreach (int number in fourtoeight)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("");
        }
    }
}
