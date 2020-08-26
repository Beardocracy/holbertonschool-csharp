using System;

/// <summary>
/// This class contains the Add method.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Multiplies two matrices and returns the resulting matrix.
    /// </summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double [,] result = new double[matrix1.GetLength(0), matrix2.GetLength(1)];

        
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
            return new double[1, 1] {{-1}};
        
        for (int rRow = 0; rRow < result.GetLength(0); rRow++)
        {
            for (int rCol = 0; rCol < result.GetLength(1); rCol++)
            {
                result[rRow, rCol] = 0;
                for (int i = 0; i < matrix1.GetLength(1); i++)
                {
                    result[rRow, rCol] += matrix1[rRow, i] * matrix2[i, rCol];
                }
            }
        }

       // Console.WriteLine(matrix1.GetLength(0) + "x" + matrix1.GetLength(1) + " X " + matrix2.GetLength(0) + "x" + matrix2.GetLength(1));
        
        return result;
    }
}