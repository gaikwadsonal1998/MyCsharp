using System;
class Getdatafrommethod{
	public static void Main(string[] args){
		
		Console.WriteLine("Enter the number of employee");
		int n = Convert.ToInt32(Console.ReadLine());
		string ename = getdata(n);
		
		Console.WriteLine("Employee name is : "+ename);
		
	}
	
	static string getdata(int empno){
		switch(empno){
			
			case 1:
			return "sonal";
			break;
			
			case 2:
			return "Vishal";
			break; 
			
			case 3:
			return "Praju";
			break;
			
			case 4:
			return "Snehal";
			break;
			
			default :
			return "No employees found";
		}
	}
}