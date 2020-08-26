using System;

/// <summary>
/// This class contains the Add method.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Calculates the determinant of a matrix.
    /// </summary>
    public static double Determinant(double[,] matrix)
    {
        double result;

        if (matrix.GetLength(1) != matrix.GetLength(0))
            return -1;
        
        if (matrix.GetLength(0) == 2)
        {
            result = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            return result;
        }
        if (matrix.GetLength(0) == 3)
        {
            result = matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]);
            result -= matrix[0,1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]);
            result += matrix[0,2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);

            return result;
        }
        
        return -1;
    }
}