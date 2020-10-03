using System;

class ArraysOfArray{
	
	public static void Main(string[] args){
		string[,] arr = new string[3,3];
		
		for(int i = 0; i < 3 ; i++)
		{	
			for(int j = 0; j < 3; j++)
			{
				arr[i,j]= Console.ReadLine();
			}
			for(int i = 0;i<3;i++)
			{
				for(int j=0;j<3;j++)
				{
					Console.WriteLine(arr[i][j]+" ");
				}
			}
		}
	}
}