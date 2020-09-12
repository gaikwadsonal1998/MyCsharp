/*
  Create a program with an integer array of size 5, 
  initialize the array with  values entered by the user.  
  If the count of input elements is greater than array size, display a message “Program tried to access index beyond the array size”.  
  If the incoming values are not integers,  then display a message “General Exception”, else display the list of values in the integer array.
  
  Inputs: 
    1 2 3 4 5
	/* Solution Logic according to asked problem statement */ 
	Expected Output = As described in the problem statement


*/

using System;

namespace LearnCsharp
{

	class TrapRunTimeErrors
	{
	    public static void Main(string[] args)
	    {
			//Update the code below
			int check = 0;
            int[] iTemp = new int[10];
            for(int i = 0 ; i < 6 ; i ++){
                var str = Console.ReadLine() ;
                int num ;
                bool parseSuccess = int.TryParse(str, out num);
                if(parseSuccess){iTemp[i] = num ;}
                else{check = 3 ; break ; } 
                
                if(iTemp[5] != 0){ check = 2 ; break;}
                else{ check = 1 ; }
            }

            int[] iValue;
            iValue = new int[5];
            

            if(check == 1)
            {
                for (int iCount = 0 ; iCount < 5 ; iCount++)
                {
                    iValue[iCount] = iTemp[iCount];    
                }               

                foreach (int iCurItem in iValue)
                {
                    Console.WriteLine(iCurItem);
                }
            }
            else if(check == 2)
            {
                Console.WriteLine("Program tried to access index beyond the array size");
            }
            else
            {
                Console.WriteLine("General Exception");
            }

	    }
	}
}