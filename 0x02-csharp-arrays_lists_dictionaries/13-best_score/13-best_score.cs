using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        List<int> valueList = myList.Values.ToList();
        if (valueList.Count == 0)
        {
            return "None";
        }
        int max = 0;
        string scorer = "";
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