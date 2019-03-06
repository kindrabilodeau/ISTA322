using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanChooseNumber_noarray_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Pick a number between 1 and 100 and I will guess what it is");
            int first = 0;
            int last = 100;
            int guess = (first + last) / 2;

            HighLow(first, last, guess);
        }

        private static void HighLow(int first, int last, int guess)
        {
            Console.WriteLine($" my guess {guess} \n " +
                $"press 1 if number is higher \n press 2 if number is lower " +
                $"\n Press 3 if my guess is right");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    if (guess == 99)
                        Win(guess = 100);
                    High(first, last, guess);
                    break;

                case 2:
                    Low(first, last, guess);
                    break;

                case 3:
                    Win(guess);
                    break;
            }
        }

        private static void High(int first, int last, int guess)
        {
            first = guess;
            guess = (first + last) / 2;
            HighLow(first, last, guess);
        }

        private static void Low(int first, int last, int guess)
        {
            last = guess;
            guess = (first + last) / 2;
            if (guess < 2)
                Win(guess = 1);
            HighLow(first, last, guess);
        }

        private static void Win(int guess)
        {
            Console.WriteLine($"Your Number Is {guess}!!");
            Console.WriteLine("Play Again? \n Press 1 for Yes \n Press 2 for no");
            int input = int.Parse(Console.ReadLine());
            int first = 0;
            int last = 100;
            int guess2 = (first + last) / 2;
            if (input == 1)
                HighLow(first, last, guess2);
            else
                Environment.Exit(0);
        }
    }
}


