using System;

/// <summary>
/// Contains methods for Vector Math.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Calculates the inverse of a 2D matrix and returns the resulting matrix.
    /// </summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        // Make sure matrix is 2x2.
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] { {-1} };

        //Find determinate.
        double det = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        
        // Check if matrix is non-invertible.
        if (det == 0)
            return new double[,] { {-1} };

        //Invert Matrix
        double[,] result = {
            {Math.Round((matrix[1, 1] / det), 2), -1 * Math.Round((matrix[0, 1] / det), 2)},
            {-1 * Math.Round((matrix[1, 0] / det), 2), Math.Round((matrix[0, 0] / det), 2)}
        };
        return result;
    }
}