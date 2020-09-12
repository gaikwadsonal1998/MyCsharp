/*

using System;

class Trialrightangle{
	public static void Main(string[] args){
		int a = int.Parse(Console.ReadLine());
		int b = int.Parse(Console.ReadLine());
		int c = int.Parse(Console.ReadLine());
		
		int a1 = ( b * b ) + ( c * c );
		int b1 = ( a * a ) + ( c * c );
		int c1 = ( a * a ) + ( b * b );
		
		if(b > a || c > a || c > b){
			Console.WriteLine("Invalid input");
		}
		else{
			if(a1==(a * a)){
				Console.WriteLine("RIGHT ANGLE TRIANGLE");
			}
			else if(b1==(b * b)){
				Console.WriteLine("RIGHT ANGLE TRIANGLE");
			}
			else if(c1==(c * c)){
				Console.WriteLine("RIGHT ANGLE TRIANGLE");
			}
			else {
				Console.WriteLine("NOT RIGHT ANGLE TRIANGLE");
			}
		}
		
	}
}
;
*/


using System;

class Trialrightangle{
	public static void Main(string[] args){
		int hyp=0;
		Console.WriteLine("Enter the sides of triangle");
		int a = int.Parse(Console.ReadLine());
		int b = int.Parse(Console.ReadLine());
		int c = int.Parse(Console.ReadLine());
		
		if(a > b && a > c){
			hyp=a;
			if(hyp * hyp == (b * b +  c * c)){
				Console.WriteLine("Right angle triangle");
			}
			else
		{
			Console.WriteLine("Not a right angle triangle");
		}
		
		}
		
		if(b > c && b > a){
			hyp=b;
			if(hyp * hyp == (a * a +  c * c)){
				Console.WriteLine("Right angle triangle");
			}
			else
		{
			Console.WriteLine("Not a right angle triangle");
		}
		
		}
		
		
		if(c > b && c > a){
			hyp=c;
			if(hyp * hyp == (b * b +  a * a)){
				Console.WriteLine("Right angle triangle");
			}
			else
		{
			Console.WriteLine("Not a right angle triangle");
		}
		
		}
		
		
	}
}