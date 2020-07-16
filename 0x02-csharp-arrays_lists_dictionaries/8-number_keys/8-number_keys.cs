using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        Dictionary<string, string>.KeyCollection keyColl = myDict.Keys;
        int count = 0;
        foreach (string s in keyColl)
        {
            count++;
        }
        return count;
    }
}