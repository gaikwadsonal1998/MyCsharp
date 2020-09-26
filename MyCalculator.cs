using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string sreply = "";

            while (sreply != "n")
            {
                Console.WriteLine("Choose which operation you want to perform : \n 1.Addition \n 2. Substraction \n 3.Multiplication \n 4.division ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        addition();
                        break;

                    case 2:
                        substraction();
                        break;

                    case 3:
                        Multiplication();
                        break;

                    case 4:
                        division();
                        break;
                }
                Console.WriteLine("*********  Press y to continue OR n to quit  **********");
                sreply = Console.ReadLine();
            }

            
        }

        static void addition() {
            Console.WriteLine("enter the number which you want to add : ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());
            int res = a1 + a2;
            Console.WriteLine("Addition of your numbers is : " +res);
        }
        static void substraction()
        {
            Console.WriteLine("enter the number which you want to Substract : ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());
            int res = a1 - a2;
            Console.WriteLine("Substraction of your numbers is : " + res);
        }

        static void Multiplication() { 
            Console.WriteLine("enter the number which you want to Multip;ly : ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());
            int res = a1 * a2;
            Console.WriteLine("Multiplication of your numbers is : " +res);
        }
        static void division()
        {
            Console.WriteLine("enter the number which you want to divide : ");
            double a1 = Convert.ToInt32(Console.ReadLine());
            double a2 = Convert.ToInt32(Console.ReadLine());
            double res = a1 / a2;
            Console.WriteLine("division of your numbers is : " + res);
        }

    }
}
