using System;

namespace Roulette1
{
    public class Util
    {
        int[] column1 = new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
        int[] column2 = new int[] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
        int[] column3 = new int[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };

        int[] row1 = new int[] { 1, 2, 3 };
        int[] row12 = new int[] { 34, 35, 36 };

        public static void EvenOdd(int number)
        {
            int[] even = new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36 };
            int[] odd = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35 };
            for (int i = 0; i < even.Length; i++)
                if (number == even[i])
                    Console.WriteLine("Bets on Even/Odd Winner: Even");
                else if (number == odd[i])
                    Console.WriteLine("Bets on Even/Odd Winner: Odd");
        }

        public static void Colorwinner(int num)
        {
            string[] color = new string[38] { "Green","Red","Black", "Red","Black","Red","Black","Red","Black", "Red","Black","Black",
                "Red","Black", "Red","Black","Red","Black","Red","Red",
                "Black", "Red","Black","Red", "Black","Red","Black","Red","Black","Black",
                "Red","Black","Red","Black","Red","Black","Red", "Green"};

            Console.WriteLine($"Bets on Color Winner:{color[num]}");
        }

        public static void HighLow(int num)
        {
            if (num > 0 && num <= 18)
                Console.WriteLine($"Bets on High/Low Winner: Low");
            else if (num >= 19 && num < 37)
                Console.WriteLine($"Bets on High/Low Winner: High");
        }

        public static void Thirds(int num)
        {
            if (num > 0 && num <= 12)
                Console.WriteLine($"Bets on Thirds Winner: First");
            else if (num >= 13 && num <= 24)
                Console.WriteLine("Bets on Thirds Winner: Second");
            else if (num >= 25 && num < 37)
                Console.WriteLine("Bets on Thirds Winner: Third");
        }

        public void Columns(int num)
        {
            for (int i = 0; i < column1.Length; i++)
                if (num == column1[i])
                    Console.WriteLine("Bets on Columns Winner: Column 1");
                else if (num == column2[i])
                    Console.WriteLine("Bets on Columns Winner: Column 2");
                else if (num == column3[i])
                    Console.WriteLine("Bets on Columns Winner: Column 3");
        }

        public void Street(int num)
        {
            for (int i = 0; i < column1.Length; i++)
                if (num == column1[i])
                    Console.WriteLine($"Bets on Streets Winners:{num}, {num + 1}, {num + 2}");
                else if (num == column2[i])
                    Console.WriteLine($"Bets on Streets Winners:{num - 1}, {num}, {num + 1}");
                else if (num == column3[i])
                    Console.WriteLine($"Bets on Streets Winners:{num - 2}, {num - 1}, {num}");
        }

        public void Doublestreet(int num)
        {
            int[] first = new int[] { 1, 2, 3, 4, 5, 6, };
            int[] second = new int[] { 7, 8, 9, 10, 11, 12 };
            int[] third = new int[] { 13, 14, 15, 16, 17, 18 };
            int[] fourth = new int[] { 19, 20, 21, 22, 23, 24 };
            int[] fifth = new int[] { 25, 26, 27, 28, 29, 30, };
            int[] sixth = new int[] { 31, 32, 33, 34, 35, 36 };
            Console.Write("Bets on Double Streets Winners:");
            for (int i = 0; i < first.Length; i++)
                if (num > 0 && num <= 6)
                    Console.Write($"{first[i]}/");
                else if (num >= 7 && num <= 12)
                    Console.Write($"{second[i]}/");
                else if (num >= 13 && num <= 18)
                    Console.Write($"{third[i]}/");
                else if (num >= 19 && num <= 24)
                    Console.Write($"{fourth[i]}/");
                else if (num >= 25 && num <= 30)
                    Console.Write($"{fifth[i]}/");
                else if (num >= 31 && num <= 36)
                    Console.Write($"{sixth[i]}/");
            Console.WriteLine();
        }

        public void Split(int num)
        {
            bool check = false;
            for (int j = 0; j < row1.Length; j++)
                for (int i = 0; i < column1.Length; i++)
                {
                    if (num != row1[j] && num != row12[j] && check == false)
                    {
                        if (column1[i] == num && check == false)
                        {
                            Console.WriteLine($"The split winners are:{num}/{num + 1},{num}/{num - 3},{num}/{num + 3}");
                            check = true;
                        }
                        else if (column2[i] == num && check == false)
                        {
                            Console.WriteLine($"The split winners are:{num - 1}/{num},{num}/{num + 1},{num}/{num - 3},{num}/{num + 3}");
                            check = true;
                        }
                        else if (column3[i] == num && check == false)
                        {
                            Console.WriteLine($"The split winners are:{num - 1}/{num},{num}/{num - 3},{num}/{num + 3}");
                            check = true;
                        }
                    }
                    else if (row1[j] == num && check == false)
                    {
                        if (column1[i] == num)
                        {
                            Console.WriteLine($"The split winners are:{num}/{num + 1},{num}/{num + 3}");
                            check = true;
                        }
                        else if (column2[i] == num)
                        {
                            Console.WriteLine($"The split winners are:{num - 1}/{num},{num}/{num + 1},{num}/{num + 3}");
                            check = true;
                        }
                        else if (column3[i] == num)
                        {
                            Console.WriteLine($"The split winners are:{num - 1}/{num},{num}/{num + 3}");
                            check = true;
                        }
                    }

                    else if (row12[j] == num && check == false)
                    {
                        if (column1[i] == num)
                        {
                            Console.WriteLine($"The split winners are:{num}/{num + 1},{num}/{num - 3}");
                            check = true;
                        }
                        else if (column2[i] == num)
                        {
                            Console.WriteLine($"The split winners are:{num - 1}/{num},{num}/{num + 1},{num}/{num - 3}");
                            check = true;
                        }
                        else if (column3[i] == num)
                        {
                            Console.WriteLine($"The split winners are:{num - 1}/{num},{num}/{num - 3}");
                            check = true;
                        }
                    }
                }
        }
        public void Corner(int num)
        {
            bool check = false;
            for (int j = 0; j < row1.Length; j++)
                for (int i = 0; i < column1.Length; i++)
                    if (num != row1[j] && num != row12[j])
                    {
                        if (num == column1[i] && check == false)
                        {
                            Console.WriteLine($"Bets on Corners Winners:{num - 3}/{num - 2}/{num}/{num + 1}, {num}/{num + 1}/{num + 3}/{ num + 4}");
                            check = true;
                        }
                        else if (num == column2[i] && check == false)
                        {
                            Console.WriteLine($"Bets on Corners Winners:{num - 4}/{num - 3}/{num - 1}/{num}," +
                                $" {num - 3}/{num - 2}/{num}/{num + 1}, {num - 1}/{num}/{num + 2}/{num + 3}, {num}/{num + 1}/{num + 3}/{num + 4}");
                            check = true;
                        }
                        else if (num == column3[i] && check == false)
                        {
                            Console.WriteLine($"Bets on Corners Winners:{num - 4}/{num - 3}/{num - 1}/{num}, {num - 1}/{num}/{num + 2}/{num + 3}");
                            check = true;
                        }
                    }
                    else if (num == row1[j] && check == false)
                    {
                        if (num == column1[i])
                        {
                            Console.WriteLine($"Bets on Corners Winners:{num}/{num + 1}/{num + 3}/{ num + 4}");
                            check = true;
                        }
                        else if (num == column2[i])
                        {
                            Console.WriteLine($"Bets on Corners Winners:{num - 1}/{num}/{num + 2}/{num + 3}, {num}/{num + 1}/{num + 3}/{num + 4}");
                            check = true;
                        }
                        else if (num == column3[i])
                        {
                            Console.WriteLine($"Bets on Corners Winners:{num - 1}/{num}/{num + 2}/{num + 3}");
                            check = true;
                        }
                    }
                    else if (num == row12[j] && check == false)
                        if (num == column1[i])
                        {
                            Console.WriteLine($"Bets on Corners Winners:{num - 3}/{num - 2}/{num}/{ num + 1}");
                            check = true;
                        }
                        else if (num == column2[i])
                        {
                            Console.WriteLine($"Bets on Corners Winners:{num - 4}/{num - 3}/{num - 1}/{num}, {num - 3}/{num - 2}/{num}/{num + 1}");
                            check = true;
                        }
                        else if (num == column3[i])
                        {
                            Console.WriteLine($"Bets on Corners Winners:{num - 4}/{num - 3}/{num - 1}/{num}");
                            check = true;
                        }
        }
    }
}