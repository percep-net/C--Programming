using System;

namespace Random_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine(random.Next(0, 7));   // Generates a random number
            // between 0 and 7.
        }
    }
}
