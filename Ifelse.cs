using System;

class Ifelse{
	public static void Main(String[] args){
		String sreply;
		sreply=Console.ReadLine();
		
		Console.WriteLine("Entered reply is :" + sreply);
		
		if(sreply=="Monday")
		{
			Console.WriteLine("This is 2nd day of the week");
		}
		else if(sreply=="Tuesday")
			{
			Console.WriteLine("This is 3rd day of the week");
		    }
			else if(sreply=="Wednesday")
			{
			Console.WriteLine("This is 4th day of the week");
		    }
			else if(sreply=="Thursday")
			{
			Console.WriteLine("This is 5th day of the week");
		    }
			else if(sreply=="Frieday")
			{
			Console.WriteLine("This is 6th day of the week");
		    }
			else if(sreply=="Saturday")
			{
			Console.WriteLine("This is 7th day of the week");
		    }
			else if(sreply=="Sunday")
			{
			Console.WriteLine("This is 1st day of the week");
		    }
			
	}
}