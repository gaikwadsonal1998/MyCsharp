/*

Coding C#:List Of Msg in Stack
bookmark_border
subject Codingcasino 100 points
DESCRIPTION
Problem Statement
Write a Program which behaves as prescribed in the below problem statement

Create a program which can save list of messages in the stack object and same should be processed (display) using a function ProcessStack.Prgram takes the input as  list of messages in a single line, and displays the all the  messages,  each message in a separate line.
Example
sample Input: 
"email from Ram at 10:10 am" "email from Ramesh at 10:15 am" "email from Rajan at 10:20 am" "email from Rakesh at 10:25 am"

Expected Output:
email from Rakesh at 10:25 am
email from Rajan at 10:20 am
email from Ramesh at 10:15 am
email from Ram at 10:10 am	
Warnings
Take care of whitespace/trailing whitespace
Trim the output and avoid special characters
Avoid printing unnecessary values other than expected/asked output
Hints
Use Split() method from the String class to process the input






EXECUTION TIME LIMIT
Default.

*/


using System;

using System.Collections;

namespace LearnCsharp
{
	
	class WorkingWithStack
	{
	    public static void Main(string[] args)
	    {
            Stack sObj;
            sObj = new Stack();
            
            String message = Console.ReadLine();
            
            String[] messageList = message.Split('\"');
            
			for(int i = 0 ; i < messageList.Length; i++){
			    if(!String.IsNullOrWhiteSpace(messageList[i]))
			        sObj.Push(messageList[i]);
			}
            ProcessStack(sObj);   
        }

        private static void ProcessStack(Stack qObj)
        {
        	foreach(Object element in qObj)
        	    Console.WriteLine(element);
        }
	}

}