using System;

namespace LearnCsharp
{

	class ArraySorting
	{
	    public static void Main(string[] args)
	    {
int[] iArray;
iArray = new int[7];
int temp = 0;
string sSortType=Console.ReadLine();
char []sSort=sSortType.ToCharArray();

string sSortingType = "Incorrect";
for(int i=0;i<7;i++){
iArray[i]=Convert.ToInt32(Console.ReadLine());
}
for (int i=0;i<iArray.Length;i++)
{
for(int j=i+1;j<iArray.Length;j++){
if(iArray[i]>iArray[j]){
temp=iArray[i];
iArray[i]=iArray[j];
iArray[j]=temp;
}
}
}
if(sSort[0] == 'D'){
sSortingType = "Descending";
Console.WriteLine("After {0} Sorting", sSortingType);
//Array.Reverse(iArray);
for(int i=iArray.Length-1;i>=0;i--)
{
Console.Write(iArray[i] + " ");
}
}
if(sSort[0] == 'A'){
sSortingType = "Ascending";
Console.WriteLine("After {0} Sorting", sSortingType);
foreach (int item in iArray)
{
Console.Write(item + " ");
}
}
}
}
}