using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Bai11_NET_Collections__Data_Structures
{
    class SortedListTest
    {
        static void Main()
        {
            SortedList mySL = new SortedList();
            mySL.Add(2, "two");
            mySL.Add(1, "one");
            mySL.Add(3, "three");

            int myKey = 2;
            Console.WriteLine("The key \"{0}\" is {1}.", myKey, mySL.ContainsKey(myKey) ? "in the SortedList" : "NOT in the SortedList");
            myKey = 4;
            Console.WriteLine("The key \"{0}\" is {1}.", myKey, mySL.ContainsKey(myKey) ? "in the SortedList" : "NOT in the SortedList");

            String myValue = "one";
            Console.WriteLine("The value \"{0}\" is {1}.", myValue, mySL.ContainsValue(myValue) ? "in the SortedList" : "NOT in the SortedList");
            myValue = "nine";
            Console.WriteLine("The value \"{0}\" is {1}.", myValue, mySL.ContainsValue(myValue) ? "in the SortedList" : "NOT in the SortedList");
        }

    }
}
