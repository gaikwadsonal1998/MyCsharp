using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExponentMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the base Number : ");
            double dbase = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Power of number : ");
            double dpow = Convert.ToDouble(Console.ReadLine());
            double result = getExpo(dbase, dpow);
            Console.WriteLine("The result is : "+result);

            Console.ReadLine();
        }
        static double getExpo(double basenum, double pownum)
        {
            double jbasenum = 1;
            for (int i = 0; i < pownum; i++)
            {
                
                jbasenum = jbasenum * basenum;
                
            }
                 return jbasenum;
        }
    }
}
