using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretword = "sonal";
            string guess = "";
            int guesscount = 0;
            int guesslimit = 3;
            bool outofguesses = false;


            while (guess != secretword && !outofguesses)
            {
                if (guesscount < guesslimit)
                {
                    Console.Write("guess the word : ");
                    guess = Console.ReadLine();
                    guesscount++;

                }
                else
                {
                    outofguesses = true;
                }
            }
            if (outofguesses)
            {
                Console.WriteLine("Ooops You loose");
            }

            else
            {
                Console.WriteLine("Congratulations........You won");
            }

            Console.ReadLine();
        }
    }
}
