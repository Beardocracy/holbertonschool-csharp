using System;
using System.Collections.Generic;


class List
{
    public static int Sum(List<int> myList)
    {
        int sum = 0;
        HashSet<int> uniqueSet = new HashSet<int>(myList);
        foreach (int element in uniqueSet)
        {
            sum += element;
        }
        return sum;
    }
}