using System;

/// <summary>
/// This class contains VectorMath functions
/// </summary>
class VectorMath
{
    /// <summary>
    /// Calculates and returns the length of a given vector.
    /// </summary>
    public static double Magnitude(double[] vector)
    {
        double mag;
        double sumOfSquares = 0;
    
        if (vector.Length > 3 || vector.Length < 2)
            return -1;
        
        for (int i = 0; i < vector.Length; i++)
            sumOfSquares += vector[i] * vector[i];

        mag = Math.Sqrt(sumOfSquares);
        return Math.Round(mag, 2);
    }
}