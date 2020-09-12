using System;

class Functions{
		public static void Main(string[] args){
			Console.WriteLine("Enter no.of elements");
			int n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter array elements");
			int[] arr = new int[n];
			for(int i=0;i<n;i++)
			{
				arr[i] = Convert.ToInt32(Console.ReadLine());
			}
			
			Console.WriteLine("Press a for ascending |||| \n b for descending");
			string r = Console.ReadLine();
			
			switch(r)
			{
				case a || A :
				ascending();
				break;
				
				case b || B :
				descending();
				break;
				
			}
		}
	
		int descending(){
			Array.Reverse(arr);
			return arr;
		}
		
		int ascending(){
			Array.sort(arr);
			return arr;
		}
}