/* Write a program to accept an array of integers. Sort the array in 
ascending or descending order according to the user’s choice.  Array elements are entered 
by the user, with the first line of input indicating A for ascending 
or D for descending sort followed by the integer values. */

using System;

namespace LearnCsharp
{

	class ArraySorting
	{
	    public static void Main(string[] args)
	    {
		
			//Update the code below
            int[] iArray;       
          //  int n = Convert.ToInt32(ReadLine());
            iArray = new int[7];
            int iTemp = 0;
           string sSortType;
            
            
            string sSortingType;
            sSortType = Console.ReadLine();
            if(sSortType == "A")
            sSortingType = "Ascending";
            else if(sSortType == "D"){
                sSortingType = "descending";
            }
            else
            {
                sSortingType = "Incorrect";
            }
            //for accepting array
            for(int i = 0 ; i < 7 ; i++)
            {
                iArray[i] = Convert.ToInt32(Console.ReadLine());
            }
			
			
//Write your code to sort an array here
            if(sSortType == "A"){
            for ( int i=0;i<7;i++ )
            {
                for(int j = i+1; j < 7 ; j++)
                {
                    if(iArray[i]>iArray[j])
                    {
                        iTemp = iArray[i];
                        iArray[i] = iArray[j];
                        iArray[j] = iTemp;
                    }
                }
            }
                   // Console.Write(iArray);
            }
            else if(sSortType == "D"){
                for ( int i=0;i<7;i++ )
            {
                for(int j = i+1; j < 7; j++)
                {
                    if(iArray[i]<iArray[j])
                    {
                        iTemp = iArray[i];
                        iArray[i] = iArray[j];
                        iArray[j] = iTemp;
                    }
                }
            }
                       // Console.Write(iArray);
            }
            else{
                Console.WriteLine(sSortingType);
            }

		
			Console.WriteLine("After {0} Sorting", sSortingType);            
            foreach (int item in iArray)
            {             
                Console.Write(item + " ");
            }
        }

	}

}