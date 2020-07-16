using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int max = -1;
        string scorer = "None";
        foreach(KeyValuePair<string, int> kvp in myList)
        {
            if (kvp.Value > max)
            {
                max = kvp.Value;
                scorer = kvp.Key;
            }
        }
        return scorer;
    }
}