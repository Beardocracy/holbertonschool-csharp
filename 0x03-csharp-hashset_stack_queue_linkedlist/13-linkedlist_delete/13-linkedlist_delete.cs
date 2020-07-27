using System;
using System.Collections.Generic;

class LList
{
   public static void Delete(LinkedList<int> myLList, int index)
    {
        if (index < 0 || index >= myLList.Count)
        {
            return;
        }
        if (index == 0)
        {
            myLList.RemoveFirst();
            return;
        }
        if (index == myLList.Count - 1)
        {
            myLList.RemoveLast();
            return;
        }
        LinkedListNode<int> current = myLList.First;
        for (int i = 0; i < index; i++)
        {
            current = current.Next;
        }
        myLList.Remove(current);
        return;

    }
}