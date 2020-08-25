using System;

/// <summary>
/// This class contains the Add method.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Adds two matrices and returns the resulting matrix.
    /// </summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double [,] result = new double[matrix1.GetLength(0), matrix1.GetLength(1)];

        if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
            return new double[1, 1] {{-1}};
        

        for (int r = 0; r < matrix1.GetLength(0); r++)
        {
            for (int c = 0; c < matrix1.GetLength(1); c++)
            {
                result[r, c] = matrix1[r, c] + matrix2[r, c];
            }
        }
        return result;
    }
}