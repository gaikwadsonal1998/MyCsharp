/*
C# Lab Exercise : Exception Handling Example1
bookmark_border
subject Codingcasino 100 points
DESCRIPTION
Complete the code as instructed in the comment section to get the below output

Sample Output :

Attempted to divide by zero.

Your array index range is exceeded than defined

I am end of all exceptions

I am after exception



Note : Refer the comments written in the code template of the coding window/tab
*/

using System;

public class ExceptionHandlingExample1
{

    public static void Main(string[] args)
    {

       
        try
        {
           //write your code that cause Division by zero exeption
           int a=5,b=0,res;
           res=a/b;
        }
        catch (ArithmeticException e)
        {
            Console.WriteLine("Attempted to divide by zero.");
        }

        try
        {
            //write your code that causes Array Index Out Of RangeException
            int[] arr=new int[5];
            int res = arr[6];
        }
        catch (IndexOutOfRangeException e1)
        {
            Console.WriteLine("Your array index range is exceeded than defined");
        }

        finally
        {
          //write your code to print "I am end of all exceptions"
            Console.WriteLine("I am end of all exceptions");
        }
        
        //write your code to print "I am after exception"
        Console.WriteLine("I am after exception");

    }

}
