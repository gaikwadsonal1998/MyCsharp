using System;

namespace LearnCsharp
{

	class SingleDimArray
	{
	    public static void Main(string[] args) 
	    {

            int[] iArray=new int[10];
	        iArray[0]=2;
	        for(int i = 1; i < 10; i++)
	        {
	            
	             int temp=Convert.ToInt32(Console.ReadLine());
	            if(temp%2==0)
	            {
	              iArray[i]=temp;
	            }
	            //else
	            //{
	            //    Console.WriteLine("invali");
	           // }
	        }

			//Add your code 


            foreach (var item in iArray)
            {
                Console.WriteLine((iArray)); 
            }
            
        }

	}

}