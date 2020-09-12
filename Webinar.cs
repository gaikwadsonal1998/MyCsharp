using System;

class Webinar{
	public static void Main(string[] args){
		Student s1 = new Student("sonal");
		Student s2 = new Student("sonal","hjj");
		
		//Student s2 = new Student();
		Console.WriteLine(s1);
	}
}
class Student{
	
		private int rollno;
		string name,degree;
		int semister;
		static int count = 0;
		public Student(string s1)
		{
			count++;
			rollno = count;
			this.name = s1 ;
		}
		
		public Student(string name, string deg){
			count++;
			rollno = count;
			this.name=name;
			this.degree = deg;
		}
		
		public Student(string name, string deg, int sem){
			count++;
			rollno = count;
			this.name=name;
			this.degree = deg;
			this.semister = sem;
		}
		
		
	
}