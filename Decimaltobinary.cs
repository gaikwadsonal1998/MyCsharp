//c# fundamentals selection statement 1 code

using System;

namespace LearnCsharp
{
	class Decimaltobinary{
	    public static void Main(string[] args) {
			
        int i = 0 ;
        int [] a = new int[10] ;
        int n  =  int.Parse(Console.ReadLine()) ;
        if(n < 1 || n > 999){
            Console.Write("INVALID_INPUT");
        }
        while(n > 1 && n <= 999){
            for(i = 0 ; n > 0 ; i++){
                a[i] = n % 2 ;
                n = n / 2 ;
            }
        }
            for(i = i - 1 ; i >= 0 ; i --){
                Console.Write(a[i]);
            
        }
	    }
	}

}