using System;

/// <summary>
/// Contains methods for Vector Math.
/// </summary>
class VectorMath
{
    /// <summary>
    /// Calculates the cross product of two 3D vectors and returns the resulting vector.
    /// </summary>
    /// <param name="vector1"></param>
    /// <param name="vector2"></param>
    /// <returns></returns>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length != 3 || vector2.Length != 3)
            return new double[] { -1 };

        double[] result = {
            vector1[1] * vector2[2] - vector1[2] * vector2[1],
            vector1[2] * vector2[0] - vector1[0] * vector2[2],
            vector1[0] * vector2[1] - vector1[1] * vector2[0]
        };
        return result;
    }
}