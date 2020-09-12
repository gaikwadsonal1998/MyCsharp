using System;

class Passbyref{
	public static void Main(string[] args){
		
		Console.WriteLine("Enter the employee no. :");
		int ieno = Convert.ToInt32(Console.ReadLine());
		string ename = "";
		int iage = 0;
		bool bstatus;
		
		bstatus = getempdetails(ieno,ref ename, ref iage);
		
		Console.WriteLine("Emp no " +ieno);
		Console.WriteLine("Employee name : "+ename);
		Console.WriteLine("Age is : "+iage);
		
		
	}
	static bool getempdetails(int iEmpno, ref string sename, ref int iage){
		
		switch(iEmpno)
		{
			case 1:
			sename = "sonal";
			iage = 22;
			return true;
			
			case 2:
			sename = "vishal";
			iage = 21;
			return true;
			
			case 3:
			sename = "praju";
			iage = 18;
			return true;
			
			case 4:
			sename = "snehal";
			iage = 16;
			return true;
			
			default:
			return false;
		}
	}
}