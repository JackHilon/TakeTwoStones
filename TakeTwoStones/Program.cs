using System;

namespace TakeTwoStones
{
    class Program
    {
        static void Main(string[] args)
        {
            // Take Two Stones
            // https://open.kattis.com/problems/twostones

            int number = EnterNum();

            string name = PlayerName(number);

            Console.WriteLine(name);
        }

        private static string PlayerName(int num)
        {
            if (num % 2 == 0)
                return "Bob";
            else
                return "Alice";
        }
        private static int EnterNum()
        {
            int a = 1;
            string str = "";
            str = Console.ReadLine();
            try
            {
                a = int.Parse(str);
                if (a < 1 || a > 10000000)
                    throw new ArgumentException();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return EnterNum();
            }
            return a;
        }
    }
}
