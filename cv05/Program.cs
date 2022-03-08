using System;
using cv05;
class Program
{
    static void Main(string[] args)
    {
        Truck tr = new Truck(50, 45, Cars.Fuel.Nafta);
        Console.WriteLine(tr.ToString());
    }
}