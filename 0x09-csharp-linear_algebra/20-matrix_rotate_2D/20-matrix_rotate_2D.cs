using System;

/// <summary>
/// This class contains the Add method.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Rotates a square 2D matrix by a given angle in radians and returns the resulting matrix.
    /// </summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] {{-1}};
        
        double [,] result = new double[2, 2];
        
        result[0, 0] = 0;
        result[0, 1] = 0;
        result[1, 0] = 0;
        result[1, 1] = 0;
        result[0, 0] += Math.Round(((matrix[0, 0] * Math.Cos(angle)) - (matrix[0, 1] * Math.Sin(angle))), 2);
        result[0, 1] += Math.Round(((matrix[0, 0] * Math.Sin(angle)) + (matrix[0, 1] * Math.Cos(angle))), 2);
        result[1, 0] += Math.Round(((matrix[1, 0] * Math.Cos(angle)) - (matrix[1, 1] * Math.Sin(angle))), 2);
        result[1, 1] += Math.Round(((matrix[1, 0] * Math.Sin(angle)) + (matrix[1, 1] * Math.Cos(angle))), 2);
    
        return result;
    }
}