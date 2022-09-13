using System;

namespace If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 6;

            if (x > y)
            {
                Console.WriteLine("x is greater than y.");
            }
            else if (x < y)
            {
                Console.WriteLine("x is less than y.");
            }
            else
            {
                Console.WriteLine("x and y are equal to each other.");
            }
        }
    }
}
