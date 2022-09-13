using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ar = new string[3];
            ar[0] = "Bonjour";
            ar[1] = "Au revoir";
            ar[2] = "Salut";

            for (int i=0; i<3; i++)
                Console.WriteLine(ar[i]);
        }
    }
}
