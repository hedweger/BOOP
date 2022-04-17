using System;

namespace cv03
{
    public class Matrix
    {
     
        double[,] Array;
        // matrix 
        public Matrix(double[,] array)
        {
            Array = array;
        }
        // tostring method
        
        public override string ToString()
        {
            string output = "";
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    output += Array[i, j] + "  ";
                }
                output = output + Environment.NewLine;
            }
            return output;
        }
        // equal size method
        private static bool EqualSize(Matrix a, Matrix b)
        {
            if (a.Array.GetLength(0) == b.Array.GetLength(0) && a.Array.GetLength(1) == b.Array.GetLength(1))
            {
                return true;
            }
            else { return false; }
        }
        // operators
        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (EqualSize(a, b) == true)
            {
                Matrix Mat = new Matrix(new double[a.Array.GetLength(0), a.Array.GetLength(1)]);
                for (int i = 0; i < a.Array.GetLength(0); i++)
                {
                    for (int j = 0; j < a.Array.GetLength(1); j++)
                    {
                        Mat.Array[i, j] = a.Array[i, j] + b.Array[i, j];
                    }
                }
                return Mat;
            }
            else { throw new Exception("Invalid size of matrix"); }
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            if (EqualSize(a, b) == true)
            {
                Matrix Mat = new Matrix(new double[a.Array.GetLength(0), a.Array.GetLength(1)]);
                for (int i = 0; i < a.Array.GetLength(0); i++)
                {
                    for (int j = 0; j < a.Array.GetLength(1); j++)
                    {
                        Mat.Array[i, j] = a.Array[i, j] - b.Array[i, j];
                    }
                }
                return Mat;
            }
            else { throw new Exception("Invalid size of matrix"); }
        }
        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (EqualSize(a, b) == true)
            {
                Matrix Mat = new Matrix(new double[a.Array.GetLength(0), a.Array.GetLength(1)]);
                for (int i = 0; i < a.Array.GetLength(0); i++)
                {
                    for (int j = 0; j < a.Array.GetLength(1); j++)
                    {
                        Mat.Array[i, j] = a.Array[i, j] * b.Array[i, j] ;
                    }
                }
                return Mat;
            }
            else { throw new Exception("Invalid size of matrix"); }
        }
        public static Matrix operator -(Matrix a)
        {
                Matrix Mat = new Matrix(new double[a.Array.GetLength(0), a.Array.GetLength(1)]);
                for (int i = 0; i < a.Array.GetLength(0); i++)
                {
                    for (int j = 0; j < a.Array.GetLength(1); j++)
                    {
                        Mat.Array[i, j] = -a.Array[i, j];
                    }
                }
                return Mat;
        }
        public static bool operator ==(Matrix a, Matrix b)
        {
            if (EqualSize(a, b) == true)
            {
                for (int i = 0; i < a.Array.GetLength(0); i++)
                {
                    for (int j = 0; j < a.Array.GetLength(1); j++)
                    {
                        if ( a.Array[i, j] != b.Array[i, j] )
                        {
                            return false;
                        }
                    }
                }
            }
            else { throw new Exception("Invalid size of matrix"); }
            return true;
        }
        public static bool operator !=(Matrix a, Matrix b)
        {
            if (EqualSize(a, b) == true)
            {
                for (int i = 0; i < a.Array.GetLength(0); i++)
                {
                    for (int j = 0; j < a.Array.GetLength(1); j++)
                    {
                        if ( a.Array[i, j] == b.Array[i,j])
                        {
                            return false;
                        }
                    }
                }
            }
            else { throw new Exception("Invalid size of matrix"); }
            return true;
        }
        public static double Determinant(Matrix a)
        {
            if (a.Array.GetLength(0) == a.Array.GetLength(1)) {
                if (a.Array.GetLength(0) == 1 && a.Array.GetLength(1) == 1)
                {
                    throw new Exception("Invalid size of matrix.");
                }
                if (a.Array.GetLength(0) == 2 && a.Array.GetLength(1) == 2)
                {
                    double determinant = a.Array[0, 0] * a.Array[1, 1] - a.Array[0, 1] * a.Array[1, 0];
                    return determinant;
                }
                if (a.Array.GetLength(0) == 3 && a.Array.GetLength(1) == 3)
                {
                    double determinant = a.Array[0, 0] * (a.Array[1, 1] * a.Array[2, 2] - a.Array[1, 2] * a.Array[2, 1]) - a.Array[0, 1] * (a.Array[1, 0] * a.Array[2, 2] - a.Array[1, 2] * a.Array[2, 0]) + a.Array[0, 2] * (a.Array[1, 0] * a.Array[2, 1] + a.Array[1,1] * a.Array[2,0]);
                    return determinant;
                }
                else { throw new Exception("Invalid size of matrix"); }
            }
            else { throw new Exception("Invalid size of matrix"); }
        }
    }
}
