/*

C# Coding : List Of Student Names(ArrayList)
bookmark_border
subject Codingcasino 100 points
DESCRIPTION
Define a method that will accept list of student names as input parameters. These names have to be filtered, sorted and displayed, filter criteria is to ensure that names do not have values like “Nobody”, “Somebody”.



Hint : Use ArrayList class to store list of names.

Do not implement the Main method

EXECUTION TIME LIMIT
Default.

*/

using System;
using System.Collections;
using System.Collections.Generic;

class CollectionExample
{
    public static void FilterNames(ArrayList al1)
    {
        al1.RemoveAt(al1.IndexOf("nobody"));
        al1.RemoveAt(al1.IndexOf("somebody"));
        
        //al1.Sort();
        
        foreach(object element in al1)
            Console.WriteLine(element);
    }
}