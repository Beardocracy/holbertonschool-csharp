using System;

namespace MyMath
{
    /// <summary>
    /// Holds methods for matrices.
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Divides all elements of a matrix.
        /// </summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
            {
                return null;
            }
            
            int[,] newArray = new int[matrix.GetLength(0), matrix.GetLength(1)];
            
            try
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        newArray[row,col] = matrix[row, col] / num;
                    }
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
            
            return newArray;
        }
    }
}
