using System;

/// <summary>
/// This class contains the Add method.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Shears a square 2D matrix by a given shear factor and returns the resulting matrix. 
    /// </summary>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double [,] result = new double[2, 2];

        
        if (matrix.GetLength(1) != 2 || matrix.GetLength(0) != 2)
            return new double[1, 1] {{-1}};
        
        if (direction == 'x')
        {
            result[0, 0] = matrix[0, 0] + factor * matrix[0, 1];
            result[0, 1] = matrix[0, 1];
            result[1, 0] = matrix[1, 0] + factor * matrix[1, 1];
            result[1, 1] = matrix[1, 1];

            return result;
        }
        if (direction == 'y')
        {
            result[0, 0] = matrix[0, 0];
            result[0, 1] = matrix[0, 1] + factor * matrix[0,0];
            result[1, 0] = matrix[1, 0];
            result[1, 1] = matrix[1, 1] + factor * matrix[1,0];
            
            return result;
        }
        /*
        for (int row = 0; row < 2; row++)
        {
            result[row, 0] = Math.Round(((matrix[row, 0] * Math.Cos(angle)) - (matrix[row, 1] * Math.Sin(angle))), 2);
            result[row, 1] = Math.Round(((matrix[row, 0] * Math.Sin(angle)) + (matrix[row, 1] * Math.Cos(angle))), 2);
        }
       */
        return new double[1, 1] {{-1}};
    }
}