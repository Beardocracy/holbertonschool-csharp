using System;

/// <summary>
/// This class contains VectorMath functions
/// </summary>
class VectorMath
{
    /// <summary>
    ///  Multiplies a vector and a scalar and returns the resulting vector
    /// </summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] result = new double[vector.Length];
    
        if (vector.Length > 3 || vector.Length < 2)
            return new double[1] {-1};
        
        for (int i = 0; i < vector.Length; i++)
            result[i] = vector[i] * scalar;

        return result;
    }
}