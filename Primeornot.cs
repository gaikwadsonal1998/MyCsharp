using System;

class Primeornot{
	public static void Main(string[] args){
		
		string msg="";
		while(msg!="n"){
		
		Console.WriteLine("Enter the number which you want to check");
		int n = int.Parse(Console.ReadLine());
		int count=0;
		
		for(int i=2; i<n;i++)
		{
			if(n%i==0)
			{
				count++;
				n=n/10;
			}
			
		}
		if(count==0){
			Console.WriteLine("Yes Is a prime");
		}
		else{
			Console.WriteLine("Not a prime");
		}
		Console.WriteLine("y to continue// n to exit");
		msg=Console.ReadLine();	
	}
	  
	}
}