using System;

class Methodoverloading{
	public static void Main(string[] args){
		
		Console.WriteLine("enter the values");
		int a = Convert.ToInt32(Console.ReadLine());
		int b = Convert.ToInt32(Console.ReadLine());
		int c = Convert.ToInt32(Console.ReadLine());
		
		string sreply ="";
		
		while(sreply!="n")
			{
		Console.WriteLine("How many numbers do you want to add");
		int noadd = Convert.ToInt32(Console.ReadLine());
		
		switch (noadd)
		{
			case 1:
				Console.WriteLine("First no is : "+a);
				break;
				
			case 2:
			int twovar = sum(a,b);
			Console.WriteLine("Sum of two variables : "+twovar);
			break;
			
			case 3:
			int threevar = sum(a,b,c);
			Console.WriteLine("Sum of three Variables : "+threevar);
			break;
		}
		Console.WriteLine("do you want to continue y / n ");
		sreply = Console.ReadLine();
		
	  }
	  
	  
		
	}
	
	static int sum(int a, int b)
	{
		return a+b;
	}
	
	static int sum(int a, int b, int c)
	{
		return a+b+c;
	}
}