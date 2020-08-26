using System;

/// <summary>
/// This class contains the Determinant method.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Transposes a matrix and return the resulting matrix.
    /// </summary>
    public static double[,] Transpose(double[,] matrix)
    {
        double[,] result = new double[matrix.GetLength(1), matrix.GetLength(0)];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                result[col,row] = matrix[row, col];
            }
        }     
        return result;
    }
}