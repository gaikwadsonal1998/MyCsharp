/*
Coding C#:Arrays 2
bookmark_border
subject Codingcasino 100 points
DESCRIPTION
Problem Statement - Sort Numbers
Complete the main method to Accept n numbers and display the numbers in ascending order as output ,if n is even. If n is odd, then display the numbers in descending order

Following requirements should be taken care in the program.

Input should be taken through Console
Program should print the output as described in the Example Section below
The first input n should represent the total number of values entered followed by the actual values to be sorted.
n should be within the range of 1 to 20 . If n is entered as less than 1 or more than 20 , it should show message as INVALID_INPUT.
Example
Sample Input 1:
7
23 
45
﻿67
﻿﻿97
65
34
74 
Expected Output:
97 74 67 65 45 34 23 

Sample Input 2:
6
77
44
﻿22
65
﻿28
﻿43
Expected Output2:
22 28 43 44 65 77
﻿
Sample Input 3:
0
Expected Output 3:
INVALID_INPUT

Sample Input 4:
30
Expected Output 4:
INVALID_INPUT
Instructions
Do not change the provided class/method names unless instructed
Ensure your code compiles without any errors/warning/deprecations
Follow best practices while coding
Avoid too many & unnecessary usage of white spaces (newline, spaces, tabs, ...), except to make the code readable
Use appropriate comments at appropriate places in your exercise, to explain the logic, rational, solutions, so that evaluator can know them
Try to retain the original code given in the exercise, to avoid any issues in compiling & running your programs
Always test the program thoroughly, before saving/submitting exercises/project
For any issues with your exercise, contact your coach
Warnings
Take care of whitespace/trailing whitespace
Trim the output and avoid special characters
Avoid printing unnecessary values other than expected/asked output


EXECUTION TIME LIMIT
Default.
*/

using System;

namespace LearnCsharp
{
	class Sortnumbers{
	    public static void Main(string[] args) {

        int n = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[n]; // Array declaration

        if ( n < 1 || n > 20)
        {

            Console.WriteLine("INVALID_INPUT");
        }

        else
        {
            //Array elements from console
            for(int i=0; i<n; i++){
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Array.Sort(a);
            
            if(n % 2 ==0){
                foreach(int element in a)
                    Console.Write(element+" ");
            
            }
            else{
                Array.Reverse(a);
                foreach(int element in a)
                    Console.Write(element+" ");
            }

                

            }

          }
	    }
	}

