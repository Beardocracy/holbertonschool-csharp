using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> keyList = myDict.Keys.ToList();
        keyList.Sort();
        foreach (string key in keyList)
        {
            Console.WriteLine(key + ": " + myDict[key]);
        }
    }
}