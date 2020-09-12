/*
C# Coding :Account Details
bookmark_border
subject Codingcasino 100 points
DESCRIPTION
Problem Statement - Account Details
Complete the class Account and AccountDetails as per the below requirement

class Account :

Create the following instance/static members:

accountNo : int

balance : double

accountType : string

counter :int static

Define parameterized constructor with two parameters to initialize balance and accountType. accountNo should be initialized by incrementing counter.

Implement the below operations:
void depositAmount(double amount)
To add amount to account balance
void printAccountDetails()
To display account details as per format given in Example Section
class AccountDetails :

Create GetData() method and follow the below instructions.
Accept balance, account type and amount as input for two account objects from Console(Refer Example section for input format)
create first object using the input data and display account details
Deposit amount using the input data and display the new account balance
create second account object using the input data and display account details.
Set account balance to new balance using input data and display the new account balance
Note : Don't Implement the Main method

Example
Sample Input:
100.5
Savings
25.5				// balance type amount for first account
200
Current
50.5				// balance type amount for second account

Expected Output:
[Acct No : 1, Type : Savings, Balance : 100.5]
New Balance : 126.0
[Acct No : 2, Type : Current, Balance : 200.0]
New Balance : 250.5
Sample Input:
0
Current 
100
0
Current 
50

Expected Output:
[Acct No : 1, Type : Current, Balance : 0.0]
New Balance : 100.0
[Acct No : 2, Type : Current, Balance : 0.0]
New Balance : 50.0
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

public class Account
{
    public int accountNo = 0;
	public double balance;
	public string accountType;
	public static int counter = 0;

	public Account(double balance, string accountType)
	{
        this.balance = balance;
        this.accountType = accountType;
        counter++;
        accountNo = counter;
    }

    public void depositAmount(double amount)
    {
        balance = balance + amount;
    }
    
    public void printAccountDetails()
    {
        Console.WriteLine("[Acct No : {0}, Type : {1}, Balance : {2}]", accountNo, accountType, balance);
    }
}
	
public	class AccountDetails
{
 
	public void GetData()
	{
	     double balance1;
	     balance1 = Convert.ToDouble(Console.ReadLine());
		 String type1;
		 type1 = Console.ReadLine();
		 double amount1;
		 amount1 = Convert.ToDouble(Console.ReadLine());
		 
		 double balance2;
		 balance2 = Convert.ToDouble(Console.ReadLine());
		 String type2;
		 type2 = Console.ReadLine();
		 //double amount2 = Convert.ToDouble(Console.ReadLine());

		
		Account a1 = new Account(balance1, type1);
		a1.printAccountDetails();
		a1.depositAmount(amount1);
		Console.WriteLine("New Balance : {0:N}");
		
		Account a2 = new Account(balance2, type2);
		a2.printAccountDetails();
		Console.WriteLine("New Balance : {0:N}");

	}
}