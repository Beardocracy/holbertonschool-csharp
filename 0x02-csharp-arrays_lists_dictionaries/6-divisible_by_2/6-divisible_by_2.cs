using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        if (myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return null;
        }
        List<bool> boolList = new List<bool>();
        foreach (int number in myList)
        {
            if (number % 2 == 0)
            {
                boolList.Add(true);
            }
            else
            {
                boolList.Add(false);
            }
        }
        return boolList;
    }
}