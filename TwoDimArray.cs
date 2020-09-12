/*

Coding C#:Two Dimensional array
bookmark_border
subject Codingcasino 100 points
DESCRIPTION
Problem Statement
Write a Program which behaves as prescribed in the below problem statement

Create a two dimensional integer array of size (2 * 2) and assign values from user input.   The output should be displayed in the form of 2*2 matrix with sum of rows and columns as show below. The last column and last row is the sum.
1|2|3
3|4|7
4|6|10
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
Inputs: 
1 
2 
3 
4
	/* Solution Logic according to asked problem statement */ 
Expected Output = As described in the problem statement
Warnings
Take care of whitespace/trailing whitespace
Trim the output and avoid special characters
Avoid printing unnecessary values other than expected/asked output
Hints/Tips
EXECUTION TIME LIMIT
Default.

*/

using System;

namespace LearnCsharp
{
   
	class TwoDimArray
	{
	    public static void Main(string[] args)
	    {
			//Update the code below
			
            int [,]iMatrix;
            iMatrix = new int[3,2];
int i,j;
            iMatrix[0, 0] = int.Parse(Console.ReadLine());
            iMatrix[0, 1] = int.Parse(Console.ReadLine());
            iMatrix[1, 0] = int.Parse(Console.ReadLine());
            iMatrix[1, 1] = int.Parse(Console.ReadLine());

            int iRowSum;
           int [] c=new int[2];
            iRowSum = 0;
            for (i=0;i<=1;i++)
        
            {c[i]=0;
                iRowSum=0;
            
                for(j=0;j<=1;j++)
                {
                    Console.Write(iMatrix[i,j]+"|");
                iRowSum =iRowSum+iMatrix[i,j];
                c[i]=c[i]+iMatrix[j,i];
                }
                Console.Write(iRowSum);
                Console.WriteLine();
            }
            
            Console.WriteLine( c[0]+"|"+c[1]+"|"+(c[0]+c[1]) );
        }
    }
}