/*
C# Coding :Customer Information
bookmark_border
subject Codingcasino 100 points
DESCRIPTION
Problem Statement - Customer Information
Create a class named SimpleDate with the below public instance variables



day:int
month:int
year:int
create constructor with parameter sequence (day,month,year)
create Getters
create setDate method with 3 parameters for changing date values
setDate(int, int, int) : void //parameter sequence (day,month,year)
Override ToString() method to return String as per below format
x/y/z
where x is day, y is month and z is year ex. 1/1/2019



create a static method as below to validate date. It should return false, if date is not valid as per given rules
validateDate(SimpleDate):boolean
Rules for date validation



Year cannot be less than 2000
month should be from 1 to 12
day should be 30 or 31 based on the month
for February, days are always 28 (No leap year validation required)
Create a class named Address with the below public instance variable



area:String
city:String
create constructor with parameter sequence (area,city)
create getters and setters
Override ToString() method to return String as per below format
xx, yy
where xx is area and yy is city

Create a class named Customer with the below public instance variables



custId:int
name:String
address:Address
registrationDate:SimpleDate
create constructor with parameter sequence(custId,name,address,registrationDate). If registrationDate is invalid, set it to null
create getter and setter for address and registrationDate. If registrationDate is invalid, set it to null
Override ToString to return string as per below format
Id : xxx, Name : xxxx
Address : xxxx, xxxx
Registered on : xxxx
If the address or registration date is null, its value should be given as "Unknown"



Id : xxx, Name : xxxx
Address : Unknown
Registered on : Unknown 
In the class CustomerInformation, do the following

Define the GetCustomer() method for the below purposes :



Accept the inputs using Console as shown in the Example section
Create object of Customer with aggregated objects of address and registration date
print the Customer details as shown in Example section
Refer Example section for Input and output format



Note : Do not implement the Main method



Example
Sample Input:
101 john			//id name
HSR Bangalore			//area city
1 1 2019			//day month year
Expected Output:
Id : 101, Name : john
Address : HSR, Bangalore
Registered on : 1/1/2019

Sample Input:
101 Dave
BTM Bangalore
30 1 1900
Expected Output:
Id : 101, Name : Dave
Address : BTM, Bangalore
Registered on : Unknown
Hints/Tips
use static method validateDate wherever validation is required in problem statement
Instructions
Do not change the provided class/method names unless instructed
Ensure your code compiles without any errors/warning/deprecations
Follow best practices while coding
Avoid too many & unnecessary usage of white spaces (newline, spaces, tabs, ...), except to make the code readable
Use appropriate comments at appropriate places in your exercise, to explain the logic, rational, solutions, so that evaluator can know them
Try to retain the original code given in the exercise, to avoid any issues in compiling & running your programs
Always test the program thoroughly, before saving/submitting exercises/project
For any issues with your exercise, contact your coach
Warnings
Take care of whitespace/trailing whitespace
Trim the output and avoid special characters
Avoid printing unnecessary values other than expected/asked output
EXECUTION TIME LIMIT
Default.
*/

using System;

public class SimpleDate
{
    public int day, month, year;
    
    public SimpleDate(int day, int month, int year){
        this.day = day;
        this.month = month;
        this.year = year;
    }

    public int getDay(){
       return day; 
    }
    public int getMonth(){
       return day; 
    }
    public int getYear(){
       return year; 
    }
    
    public void setDate(int day, int month, int year){
        this.day = day;
        this.month = month;
        this.year = year;
    }
    
    public override string ToString(){
        return day.ToString() + "/" + month.ToString() + "/" + year.ToString();
    }
    
    public static bool validateDate(SimpleDate date){
        return false;
    }   
}

public class Address
{
    public string area;
    public string city;
    
    public Address(string area, string city){
        this.area = area;
        this.city = city;
    }
    
    public string getArea(){
        return area;
    }
    public string getCity(){
        return city;
    }
    
    public void setArea(string area){
        this.area = area;
    }
    
    public void setCity(string city){
        this.city = city;
    }
    
    public override string ToString(){
        return area + ", " +city;
    }
}

public class Customer
{
    public int custId;
    public string name;
    public Address address;
    public SimpleDate registrationDate;
    
    public Customer(int custId, string name, Address address, SimpleDate registrationDate){
        this.custId = custId;
        this.name = name;
        this.address = address;
        this.registrationDate = registrationDate;
    }
    
    public Address getAddress(){
        return address;
    }
    
    public SimpleDate getRegistrationDate(){
        return registrationDate;
    }
    
    public override string ToString(){
        return "Id :" + custId +", Name :" + name + "\n" +"Address :" + getAddress() + "\n" + "Registered on:" + getRegistrationDate();
    }
}

public class CustomerInformation
{
    void GetCustomer()
    {
        int custId = Convert.ToInt32(Console.ReadLine());
        string name = Console.ReadLine();
        string area = Console.ReadLine();
        string city = Console.ReadLine();
        int day = Convert.ToInt32(Console.ReadLine());
        int month = Convert.ToInt32(Console.ReadLine());
        int year = Convert.ToInt32(Console.ReadLine());
       
        SimpleDate simpleDate = new SimpleDate(day, month, year);
        Address address = new Address(area, city);
        Customer customer = new Customer(custId, name, address, simpleDate);
        Console.WriteLine(customer);
        
    }
}