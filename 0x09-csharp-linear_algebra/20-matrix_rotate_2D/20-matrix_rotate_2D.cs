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
        double [,] rotMat = new double[,] {
            {Math.Cos(angle), Math.Sin(angle)},
            {-1 * Math.Sin(angle), Math.Cos(angle)}
        };
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    result[i, j] = Math.Round(result[i,j] + matrix[i, k] * rotMat[k, j], 2);
                }
            }
        }
    
        return result;
    }
}