/*
Write a program to initialize a single dimensional array of any size with integer values . Display the complete array content with count of the numbers which are divisible by 5 to the end.
Size of the array is first input to the program followed by the elements of the array.
Coding C#:Array and Multiples of 5
bookmark_border
subject Codingcasino 100 points
DESCRIPTION
Problem Statement
Write a Program which behaves as prescribed in the below problem statement

Write a program to initialize a single dimensional array of any size with integer values . Display the complete array content with count of the numbers which are divisible by 5 to the end.
Size of the array is first input to the program followed by the elements of the array.
Assume all input values are >= 5
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
Sample Input :
7       //Size of the array
5
﻿10
15
16
﻿1
10
﻿21
Expected Output :
Count of elements divide by 5: 4
Warnings
Take care of whitespace/trailing whitespace
Trim the output and avoid special characters
Avoid printing unnecessary values other than expected/asked output
Hints/Tips


EXECUTION TIME LIMIT
Default.
Solution code
Please choose a language and write your code.
check_circleACCEPTED
Score: 100 points(details)
CODEINPUTOUTPUTCODEINPUTOUTPUT
C#

info_outline
1 revision found for this solution.

*/

using System;

namespace LearnCsharp
{
	
	class CountOfDivideByFive
	{
	    public static void Main(string[] args)
	    {
			//Update the code below
			int n = Convert.ToInt32(Console.ReadLine());
			  int[] iArray;
            iArray = new int[n];
            int iCount = 0;


            for (int iVal1 = 0; iVal1<n  ;iVal1++ )
            {
                  iArray[iVal1]=Convert.ToInt32(Console.ReadLine());
            }
            
            for(int i=0 ; i < n ; i++){
                if(iArray[i]%5==0){
                    iCount++;
                }
            }

            foreach (int item in iArray)
            {
               Console.WriteLine(item);
            }
            Console.WriteLine("Count of elements divide by 5: " + iCount);
	    }
	}

}