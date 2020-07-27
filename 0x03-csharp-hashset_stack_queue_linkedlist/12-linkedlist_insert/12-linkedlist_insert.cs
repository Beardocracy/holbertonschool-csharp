using System;
using System.Collections.Generic;

class LList
{
   public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
       LinkedListNode<int> newNode = new LinkedListNode<int>(n);
       if (myLList.Count == 0)
       {
           myLList.AddFirst(newNode);
           return newNode;
       }
       LinkedListNode<int> current = myLList.First;
       if (current.Value > n)
       {
           myLList.AddFirst(newNode);
           return newNode;
       }
       while (current != null)
       {
           if (current.Value <= n && (current.Next == null || current.Next.Value >= n))
           {
               myLList.AddAfter(current, newNode);
               break;
           }
           current = current.Next;
       }
       return newNode;
    }
}