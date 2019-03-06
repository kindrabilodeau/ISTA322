using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerChooseNumber_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black; 
            NewNumber(); 
        }

        private static void NewNumber()
        {
            Console.WriteLine("I will choose a number between 1 - 1000 and you try to guess it.");
            Random rand = new Random();
            int attempt = rand.Next(1,1001);

            //Console.WriteLine($"Random number is:{attempt}");  --This is here for testing purposes. 
            Guess(attempt); 
        }

        private static void Guess(int attempt)
        {
            Console.WriteLine("What is your guess?");
            int input = int.Parse(Console.ReadLine());

            if (input > attempt)
            {
                Console.WriteLine("Ha! Your guess is too high!!! TRY AGAIN");
                Guess(attempt); 

            }
            else if (input < attempt)
            {
                Console.WriteLine("HAHAHA! Your guess is too low!! TRY AGAIN");
                Guess(attempt);
            }
            else if (input == attempt)
                Console.WriteLine("Hmm.. I'm not sure how but your guess is correct");
                Console.WriteLine("I suppose you win... Play Again?");
                Console.WriteLine("Press 1 for YES. Press 2 for NO.");
            int again = int.Parse(Console.ReadLine());
            if (again == 1)
                NewNumber(); 
            else 
                Environment.Exit(0);
        }
    }
}
