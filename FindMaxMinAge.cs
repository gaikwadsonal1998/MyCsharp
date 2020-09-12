/*
Coding C#:Arrays 1
bookmark_border
subject Codingcasino 100 points
DESCRIPTION
Problem Statement - Find Maximum and Minimum Age
Complete the main method to accept the age of n students and find the maximum and minimum age .

The first input is the number n representing the number of age values you need to enter as integers

Followed by the age values in a separate line.

The output should display as shown below in sample input /output.

Following requirements should be taken care in the program.

Input should be taken through Console
Program should print the output as described in the Example Section below
The number n representing the number of students should be allowed in the range of 1 to 20
If n is entered less than 1 or more than 20 , it should print message as INVALID_INPUT.
Example
Sample Input 1:
5
34 
56 
12 
﻿89 
43
Sample Ouptut 1:
MIN=12
MAX=89


Sample Input 2:
25 
Expected Output:
INVALID_INPUT

 
Sample Input 3:
8
78 
44 
23 
65 
45 
9 
23 
39
Expected Output:
MIN=9
MAX=78
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
	class FindMaxMinAge{
	    public static void Main(string[] args) {
	        
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr= new int[n];
       
        
        if ( n < 1 || n > 20 )
        {
            Console.WriteLine("INVALID_INPUT");
        }
        else
        {
			 for(int i=0;i<n;i++)
        {
            arr[i]= Convert.ToInt32(Console.ReadLine());
        }
         int min = arr[0];
         int max = arr[0];
			
            for(int i=0; i < n; i ++){
           if (min > arr[i]) 
              min = arr[i];
             if (max < arr[i])
            max= arr[i];  
            }
//student code goes here
            Console.WriteLine("MIN=" + min);

            
       //student code goes here     

            Console.WriteLine("MAX=" + max);
        }
        
	    }
	}
}