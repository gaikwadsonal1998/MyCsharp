// C# FUNDAMENTALS SELECTION STATEMENT - 2
using System;

namespace LearnCsharp
{
	class Rightangletriangle{
	    public static void Main(string[] args) {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int c1 = ( a * a ) + ( b * b ) ;
        int a1 = ( b * b ) + ( c * c ) ;
        int b1 = ( a * a ) + ( c * c ) ;
        if( b > a || c > a || c > b){
            Console.Write("INVALID_INPUT");
        }
        else{
            if( a1 == ( a * a )){
                Console.Write("RIGHT ANGLE TRIANGLE");
            }
            else if( b1 == ( b * b )){
                Console.Write("RIGHT ANGLE TRIANGLE");
            }
            else if( c1 == ( c * c )){
                Console.Write("RIGHT ANGLE TRIANGLE");
            }
            else{
                Console.Write("NOT RIGHT ANGLE TRIANGLE");
            }
        }
	}

}
}