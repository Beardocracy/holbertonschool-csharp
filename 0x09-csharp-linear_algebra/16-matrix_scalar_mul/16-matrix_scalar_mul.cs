using System;

/// <summary>
/// This class contains the Add method.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Multiplies a matrix and a scalar and returns the resulting matrix.
    /// </summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double [,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];

        if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(0) < 2 || matrix.GetLength(0) > 3)
            return new double[1, 1] {{-1}};
        

        for (int r = 0; r < matrix.GetLength(0); r++)
        {
            for (int c = 0; c < matrix.GetLength(1); c++)
            {
                result[r, c] = matrix[r, c] * scalar;
            }
        }
        return result;
    }
}