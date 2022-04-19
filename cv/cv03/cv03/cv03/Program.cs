using System;

namespace cv03
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] MatA = new double[,]
            {
                {1,1 },
                {1,1 },
            };
            double[,] MatB = new double[,]
            {
                {3,2,2 },
                {2,2,3 },
                {2,3,3 },
            };
            double[,] MatC = new double[,]
           {
                {2,2 },
                {2,2 },
           };
            double[,] MatD = new double[,]
          {
                {2,3 },
                {2,3 },
          };
            Matrix MA = new Matrix(MatA);
            Matrix MB = new Matrix(MatB);
            Matrix MC = new Matrix(MatC);
            Matrix MD = new Matrix(MatD);

            var MP = MA + MA;
            Console.WriteLine("Addition:");
            Console.WriteLine("{0}", MP);

            var MS = MC - MA;
            Console.WriteLine("Subtraction:");
            Console.WriteLine("{0}", MS);

            var MM = MC * MD;
            Console.WriteLine("Multiplication:");
            Console.WriteLine("{0}", MM);

            var MU = -MC;
            Console.WriteLine("Unary -:");
            Console.WriteLine("{0}", MU);

            var ME = MA == MC;
            var ME2 = MA == MA;
            Console.WriteLine("Boolean ==:");
            Console.WriteLine("{0}", ME);
            Console.WriteLine("{0}", ME2);

            var MD2 = Matrix.Determinant(MC);
            Console.WriteLine("\nDeterminant :");
            Console.WriteLine("{0}", MD2);

            var MD3 = Matrix.Determinant(MB);
            Console.WriteLine("\nDeterminant :");
            Console.WriteLine("{0}", MD3);
        }
    }
}
