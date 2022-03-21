using System;
namespace cv07
{
    public abstract class Object2D : I2D, IComparable
    {
        public Object2D()
        {
            
        }
        public abstract double Area();
        public int CompareTo(object obj)
        {
            if (((Object2D)obj).Area() == this.Area())
            {
                return 0;
            }
            else { return 1; }
        }
    }
}