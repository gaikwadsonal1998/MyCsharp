/* 
C# Coding : Shape Hierarchy
bookmark_border
subject Codingcasino 100 points
DESCRIPTION
Create an interface named Shape with the following abstract methods



getArea() : double ( return type is double)
getPerimeter() : double
Create an abstract class named AbstractShape which implements Shape interface with the below public instance variable



colour:String
create parameterized constructor
Override ToString() method to return String as per below format
colour=X
where X represents value of colour variable

Create a concrete subclass of Abstract Shape named Rectangle with the below public instance variables





length:int
breadth:int
create constructor with 3 parameters to initialize colour, length and breadth properties of Rectangle in the given sequence
implement the inherited methods getArea and getPerimeter using appropriate formulas for Rectangle[Refer Hints Section]
Override ToString to return String as per below format
Rectangle [colour=X, length=X, breadth=X]
where X represent respective values of variables

Create another concrete subclass of AbstractShape named Circle with the below instance variable



radius:int
create constructor with 2 parameters to initialize colour and radius properties of Circle in the given sequence
implement the inherited methods getArea and getPerimeter using appropriate formulas for Circle[Refer Hints Section]
Override ToString to return String as per below format
Circle [colour=X, radius=X]
where X represent respective values of variables

In the class ShapeDemo, do the following

Create a static method named printShape which should be able to take any shape object as parameter. This method should display the area and perimeter of the input shape object in the below format.



Area: X,Perimeter: X
where X represent the respective values.The area and perimeter should be rounded to the nearest integer and displayed

In the getData() method, do the following



Accept first input as CIRCLE or RECTANGLE.
If first input is CIRCLE, Accept colour and radius
If first input is RECTANGLE, Accept colour, length and breadth
Create object of Circle or Rectangle based on first input and print the details of object.
Call printShape to print the Area and Perimeter.


Note: Do not implement the Main method
Refer Example section for Input and output format



Example
Sample Input:
CIRCLE
RED
﻿ 5

Expected Output:
Circle [colour=RED, radius=5]
Area: 79,Perimeter: 31
Sample Input:
RECTANGLE
GREEN 
10 
5

Expected Output:
Rectangle [colour=GREEN, length=10, breadth=5]
Area: 50,Perimeter: 30
Hints/Tips
Circle Formulas
Area 		: Pi x r x r
Perimeter	: 2 x Pi x r
Rectangle Formulas
Area 		: l x b
Perimeter 	: 2 x (l+b)
Use static variable PI of Math class
Use Math.round(..) for rounding a double to nearest integer. Rounding should be done in printShape method

EXECUTION TIME LIMIT
Default.
Solution code
Please choose a language and write your code.
info_outlineUNSOLVED
CODEINPUTOUTPUTCODEINPUTOUTPUT
C#


 */
 
 using System;

public interface Shape
{
    double getArea();
    double getPerimeter();
}

public abstract class AbstractShape : Shape
{
    public string colour;
    
    public AbstractShape(){
        
    }
    
    public abstract double getArea();
    public abstract double getPerimeter();

    AbstractShape(string colour){
        this.colour = colour;
    }
    
    public override string ToString(){
        return "colour=" + colour;
    }
}
public class Rectangle : AbstractShape
{
    public int length, breadth;
    
    public Rectangle(string colour, int length, int breadth){
        this.colour = colour;
        this.length = length;
        this.breadth = breadth;
    }
    
    public override double getArea(){
        return length * breadth;
    }
    
    public override double getPerimeter(){
        return 2 * (length + breadth);
    }
    
    public override string ToString(){
        return "Rectangle [colour=" + colour + ", length=" + length + ", breadth=" + breadth + "]";
    }
}

public class Circle : AbstractShape
{
    public int radius;
    
    public Circle(string colour, int radius){
        this.colour = colour;
        this.radius = radius;
    }
    
    public override double getArea(){
        return Math.PI * radius * radius;
    }
    
    public override double getPerimeter(){
        return 2 * Math.PI * radius;
    }
    
    public override string ToString(){
        return "Circle [colour=" + colour + ", radius=" + radius + "]";
    }
}

class ShapeDemo
{
    public static void printShape(Shape obj){
        Console.WriteLine("Area: "+ Math.Round(obj.getArea()) + ",Perimeter: " + Math.Round(obj.getPerimeter())); 
    }
    
    public static void getData(){
        string shape = Console.ReadLine();
        
        if(shape == "CIRCLE"){
            string colour = Console.ReadLine();
            int radius = Convert.ToInt32(Console.ReadLine());
            
            Circle circle = new Circle(colour, radius);
            printShape(circle);
        }
        else{
            string colour = Console.ReadLine();
            int length = Convert.ToInt32(Console.ReadLine());
            int breadth = Convert.ToInt32(Console.ReadLine());
            
            Rectangle rectangle = new Rectangle(colour, length, breadth);
            printShape(rectangle);
        }
    }
}