using System;

class Switchconstruct{
	public static void Main(string[] args) {
	string sreply;
	sreply=Console.ReadLine();
	
	switch(sreply)
	{
		case "Sunday" : 
		case "sunday" : 
		case "Sun" :
		Console.WriteLine("Enter day is 1st day of week ");
		break;
		
		case "Monday" :
		case "monday" : 
		case "Mon" :
		Console.WriteLine("Enter day is 2nd day of week ");
		break;
		
		case "Tuesday" :
		case "tuesday" :
		case "Tue" :
		Console.WriteLine("Enter day is 3rd day of week ");
		break;
		
		case "Wednesday" :
		case "wednesday" :  
		case "Wed" : 
		Console.WriteLine("Enter day is 4th day of week ");
		break;
		
		case "Thursday" :
		case "thursday" :
		case "Thu" :
		Console.WriteLine("Enter day is 5th day of week ");
		break;
		
		case "Frieday" :
		case "frieday" :
		case "Fri" :
		Console.WriteLine("Enter day is 6th day of week");
		break;
		
		case "Saturday" :
		case "saturday" :
		case "Sat" :
		Console.WriteLine("Enter day is 7th day of week ");
		break;
	}
}
}