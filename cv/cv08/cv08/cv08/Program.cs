using System;

namespace cv08
{
    class Program
    {
        static void Main(string[] args)
        {
            TempArchive temp = new TempArchive();
            Console.WriteLine("Read from file:");
            temp.Load("readtemps.txt");
            temp.PrintTemps();
            temp.Save("savetemps.txt");
            Console.WriteLine("");
            Console.WriteLine("Find:");
            temp.Find(2013);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("M Average temps:");
            temp.PrintAverageMonthlyTemps();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Y Average temps");
            temp.PrintAverageTemps();
            Console.WriteLine("");
            Console.WriteLine("Calibrate:");
            temp.Calibrate(0.1);
            Console.WriteLine("");
                      
        }
    }
}
