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
        // Check if matrix is square.
        if (matrix.GetLength(1) != matrix.GetLength(0))
            return -1;
        
        // Calculates determinant for 2x2 matrix.
        if (matrix.GetLength(0) == 2)
        {
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }
        // Calculates determinant for 3x3 matrix.
        if (matrix.GetLength(0) == 3)
        {
            double result;

            result = matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]);
            result -= matrix[0,1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]);
            result += matrix[0,2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);

            return Math.Round(result, 2);
        }
        
        return -1;
    }
}