public class Matrix {
    private double [,] PrivMatrix;
    public Matrix(double[,] PrivMatrix) {
        this.PrivMatrix = Matrix;
    }
    public override string ToString() {
        
    }
    public static Matrix operator +(Matrix a, Matrix b) {
        if (a.GetLength(0) < 4 && a.GetLength(1) < 4 && b.GetLength(0) < 4 && b.GetLength(1) < 4) {
            double Mat = new Matrix(new double[a.GetLength(0),a.GetLength(1)]);
            for (int i; i < a.GetLength(0); i++) {
                for (int j; j < a.GetLength(1); j++) { Mat[i,j] = a[i,j] + b[i,j]; }
            }
            return Mat;
        }
        else {
            throw new Exception("Špatná velikost matice.");
        }
    }

        public static Matrix operator -(Matrix a, Matrix b) {
        if (a.GetLength(0) < 4 && a.GetLength(1) < 4 && b.GetLength(0) < 4 && b.GetLength(1) < 4) {
            double Mat = new Matrix(new double[a.GetLength(0),a.GetLength(1)]);
            for (int i; i < a.GetLength(0); i++) {
                for (int j; j < a.GetLength(1); j++) { Mat[i,j] = a[i,j] - b[i,j]; }
            }
            return Mat;
        }
        else {
            throw new Exception("Špatná velikost matice.");
        }
    }
}