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
        double [,] result = new double[2, 2];

        
        if (matrix.GetLength(1) != 2 || matrix.GetLength(0) != 2)
            return new double[1, 1] {{-1}};
        
        for (int row = 0; row < 2; row++)
        {
            result[row, 0] = Math.Round((matrix[row, 0] * Math.Cos(angle) - matrix[row, 1] * Math.Sin(angle)), 2);
            result[row, 1] = Math.Round((matrix[row, 0] * Math.Sin(angle) + matrix[row, 1] * Math.Cos(angle)), 2);
        }
       
       // Console.WriteLine(matrix1.GetLength(0) + "x" + matrix1.GetLength(1) + " X " + matrix2.GetLength(0) + "x" + matrix2.GetLength(1));
        
        return result;
    }
}