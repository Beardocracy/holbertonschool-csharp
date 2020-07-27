using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int index = -1;
        int[] array = new int[myLList.Count];
        myLList.CopyTo(array, 0);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == value)
            {
                index = i;
                break;
            }
        }
        return index;
    }
}