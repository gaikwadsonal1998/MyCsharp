//C# Fundamentals LOOPS - 3

using System;

namespace LearnCsharp
{
	class Armstrongnumber{

     static int power(int n, int r)
    {
        double p = Math.Pow( n , r );
        return (int)p;
    }


    public static void Main(String[] args)
    {
            int num  =  int.Parse(Console.ReadLine()) ;
            int temp = num ;
            int sum = 0 , pow = 0 , rem = 0 ;
            
            while( temp != 0){
                pow += 1 ;
                temp = temp / 10 ;
            }
            
            if(pow != 3){
                Console.Write("INVALID_INPUT");
            }
            else{
            temp = num ;
            
            while ( temp != 0)
            {
                rem = temp % 10 ;
                sum = sum + power( rem , pow) ;
                temp = temp / 10 ;
            }

            if (sum == num)
                Console.WriteLine("ARMSTRONG");
	      else
	         Console.WriteLine("NOT ARMSTRONG");
  	}
	    
	}
	}

}