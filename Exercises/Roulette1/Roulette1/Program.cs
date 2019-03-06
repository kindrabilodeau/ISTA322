using System;


namespace Roulette1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[38] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23,
                24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 00 };

            string[] color = new string[38] { "Green","Red","Black", "Red","Black","Red","Black","Red","Black", "Red","Black","Black",
                "Red","Black", "Red","Black","Red","Black","Red","Red",
                "Black", "Red","Black","Red", "Black","Red","Black","Red","Black","Black",
                "Red","Black","Red","Black","Red","Black","Red", "Green"};

            Console.WriteLine("This is the wheel: ");
            for (int i = 0, j = 0; i < nums.Length; i++, j++)
            {
                //Console.WriteLine($"{nums[i]} = {color[j]}");
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Util classUtil = new Util();
                Console.WriteLine($"The ball lands on {nums[i]}");
                Console.WriteLine($"Bets on the Number Winner:{nums[i]}");
                Util.EvenOdd(nums[i]);
                Util.Colorwinner(i);
                Util.HighLow(i);
                Util.Thirds(i);
                classUtil.Columns(i);
                classUtil.Street(i);
                classUtil.Doublestreet(i);
                classUtil.Split(nums[i]);
                classUtil.Corner(i);
                Console.WriteLine();
            }
        }
    }
}
