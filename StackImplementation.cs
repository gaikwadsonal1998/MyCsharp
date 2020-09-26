using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;

class StackImplementation{
	public static void Main(string[] args){
		
		Stack sobj;
		sobj = new Stack();
		
		sobj.Push("Sonal");
		sobj.Push("Vishal");
		
		foreach(IEnumerable ie in sobj){
			Console.WriteLine(ie);
		}
		
		sobj.Pop();
		Console.WriteLine("Element count after Popping : " +sobj.Count);
		Console.WriteLine("***************************************");
		foreach(IEnumerable ie in sobj){
			Console.WriteLine(ie);
		}
		
	}
}