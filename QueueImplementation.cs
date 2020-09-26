using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

class QueueImplementation{
		
		public static void Main(string[] args){
		Queue obj;
		obj = new Queue();
		
		obj.Enqueue("Sonal");
		obj.Enqueue("Vishal");
		foreach(IEnumerable ie in obj){
			Console.WriteLine(ie);
		}
			Console.WriteLine("No.of elements : "+obj.Count);
		}
}