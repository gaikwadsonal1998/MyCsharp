/*
C# Lab : Interface Example2
bookmark_border
subject Codingcasino 100 points
DESCRIPTION
Write a program as described below



Create an interface I1 containing method with signature :void method1( )
Create interface I2 derived from interface I1.
I2 has method with signature : void method2( )
Create abstract class Class1 that implements interface I2.
Define method1() in Class1 in such a way , it prints "I am from interface I1" when invoked in the Main method
Define method2() in Class1 in such a way , it prints "I am from interface I2" when invoked in the Main method
method3 is an abstract method inside Class1
Define the class InterfaceExample2 inherited from Class1
method3() prints " I am from abstract class" when invoked.
Sample Output :

I am from interface I1

I am from interface I2

I am from abstract class
*/

using System;


interface I1
{
    //write your code 
      void method1();
}

interface I2 : I1
{
	//write your code
	  void method2( );
}

public abstract class Class1 : I2
{
    //write your code
     public void method1(){
        Console.WriteLine("I am from interface I1");
    }
    
   public void method2(){
        Console.WriteLine("I am from interface I2");
    }
    
    public abstract void method3();
}


public class InterfaceExample2 : Class1
{

//write your code to define method3
    public override void method3(){
      Console.WriteLine("I am from abstract class");
  }

public static void Main(string[] args)
{
    
    InterfaceExample2 i = new InterfaceExample2();
    i.method1();
    i.method2();
    i.method3();

}

}
