using System;

class Primeranges{
	public static void Main(string[] args){
		
		int count;
		Console.WriteLine("Enter the number upto which you want a prime numbers");
		int n= int.Parse(Console.ReadLine());
		
		for(int i=0;i<=n;i++){
			count=0;
			for(int j=1;j<=i;j++){
				if(i%j==0){
					count++;
				}
				
			}
			if(count==2)
				Console.Write(i+ " ");
		}
		//Console.ReadKey();
		//if(count==0)
		
	}
}