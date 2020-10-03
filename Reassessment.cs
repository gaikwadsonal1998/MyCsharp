using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


	public class Employee
	{
	//Write your code here 
	private string empCode, empName;
	private double empSal;
	private char deptCode;
	private static int empCounter = 1000;
	
 
 public string EmpCode
 {
     get { return empCode;}
     set { empCode = value;}
 }
 public string EmpName
 {
     get { return empName;}
     set { empName = value;}
 }
 public double EmpSal
 {
     get { return empSal;}
     set { empSal = value;}
 }
 public char DeptCode
 {
     get { return deptCode;}
     set { deptCode = value;}
 }
 public int EmpCounter
 {
  get { return empCounter;}
     set { empCounter = value;}
 }
 
 private string generateEmployeeCode()
 {
     return Convert.ToString(++empCounter) + Convert.ToString(deptCode);
 }
 
 public Employee(string empName,double empSal,char deptCode)
 {
     this.empName = empName;
     this.empSal = empSal;
     this.deptCode = deptCode;
     this.empCode = generateEmployeeCode();
 }
 
 public Employee(string empName,double empSal)
 {
     this.empName = empName;
     this.empSal = empSal;
     DeptCode =
'A';
     this.empCode = generateEmployeeCode();
 }
 
 public string getEmployeeDetails()
 {
     return "Code-"+empCode+",Name-"+empName+",Salary-"+empSal+",Department"+deptCode;
 }
  
  }
  

    