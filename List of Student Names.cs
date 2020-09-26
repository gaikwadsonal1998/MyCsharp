/*
Coding C#:List of Student Names
bookmark_border
subject Codingcasino 100 points
DESCRIPTION
Problem Statement
Write a Program which behaves as prescribed in the below problem statement

Create a program which will accept list of student names as input, these names have to be filtered, sorted and displayed, filter criteria is to ensure that names do not have values like “Nobody”, “Somebody”.

Take input/output as specified
Print the expected output using the expected logic/algorithm/data
Code is structured correctly and according to the problem statement
Instructions
Ensure your code compiles without any errors/warning/deprecations
Follow best practices while coding
Avoid too many & unnecessary usage of white spaces (newline, spaces, tabs, ...), except to make the code readable
Use appropriate comments at appropriate places in your exercise, to explain the logic, rational, solutions, so that evaluator can know them
Try to retain the original code given in the exercise, to avoid any issues in compiling & running your programs
Always test the program thoroughly, before saving/submitting exercises/project
For any issues with your exercise, contact your coach
Example
Sample Input:
Ravi 
Somebody 
Tanvir 
Ramesh 
Nobody 
Ani
Nobody 
Vishwanath
Somebody 
Nitin

Expected output :
Ani
Nitin
Ramesh
Ravi
Tanvir
Vishwanath﻿
﻿
Warnings
Take care of whitespace/trailing whitespace
Trim the output and avoid special characters
Avoid printing unnecessary values other than expected/asked output
Hints/Tips


EXECUTION TIME LIMIT
Default.
*/

using System;

using System.Collections;

namespace LearnCsharp
{

	class NamesWithArrayList
	{
	    public static void Main(string[] args)
	    {
	        ArrayList alObj;
            alObj = new ArrayList();
            int max=10;
            string item="";
            for(int i=0;i<max;i++)
            {
                item = Console.ReadLine();
                if(item != "Somebody" && item !="Nobody")
                    alObj.Add(item);
            }
            
            alObj.Sort();
            
            foreach (var item1 in alObj)
            {
                Console.WriteLine(item1);
            }
        }
	}

}