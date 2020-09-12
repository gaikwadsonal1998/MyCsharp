/*
Write a program to accept an array of integers. Sort the array in ascending or descending order according to the user’s choice. 
 Array elements are entered by the user, with the first line of input indicating 
 A for ascending or D for descending sort followed by the integer values.

Sample Input: 
A 
5 
10
15
﻿﻿16
1
﻿10 
21

Expected Output :
﻿After Ascending Sorting
1 5 10 10 15 16 21 
*/
using System;
namespace LearnCsharp
{

class ArraySorting
{
public static void Main(string[] args)
{

//Update the code below
int?[] iArray;
int n = 7;
iArray = new int?[n];
int iTemp = 0;
string sSortType = Console.ReadLine();
char[] sSort = sSortType.ToCharArray();
string sSortingType = "";
string str;
while((str = Console.ReadLine())!=null){
iArray[iTemp] = Convert.ToInt32(str);
iTemp++;
}

//Write your code to sort an array here
if(sSort[0] == 'A' || sSort[0] == 'a'){
Array.Sort(iArray);
sSortingType = "Ascending";
Console.WriteLine("After {0} Sorting", sSortingType);
for(int i = n-iTemp;i<n;i++)
Console.Write(iArray[i]+" ");
}
else if (sSort[0] == 'D' || sSort[0] == 'd'){
sSortingType = "Descending";
Array.Sort(iArray);
Array.Reverse(iArray);
Console.WriteLine("After {0} Sorting", sSortingType);
for(int i =0;i<iTemp;i++)
Console.Write(iArray[i]+" ");
}
}

}

}