using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        int result = 0;
        bool flag = true;
        List<int> results = new List<int>();
        for (int i = 0; i < listLength && flag; i++)
        {
            result = 0;
            try
            {
                result = list1[i] / list2[i];
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
                flag = false;
            }
            finally
            {
                if (flag)
                {
                    results.Add(result);
                }
            }
        }
        return results;
    }
}