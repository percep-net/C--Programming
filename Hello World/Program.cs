using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!"); // I'm a comment.

            /*
             * I'm a multiline comment.
             */
            string friend = "Paul";
            Console.WriteLine(friend);
            Console.WriteLine("Hello " + friend);
            Console.WriteLine($"Hello {friend}");

            friend = "Marie";
            Console.WriteLine($"Hello {friend}");
            Console.WriteLine($"{friend}'s name has {friend.Length} characters.");

            friend = "Adam";
            Console.WriteLine($"{friend}'s name in uppercase: " + friend.ToUpper());
            Console.WriteLine($"{friend}'s name in lowercase: " + friend.ToLower());

            friend = "    Jack    ";
            Console.WriteLine(friend.Trim());   // TrimStart(), TrimEnd()

            string hello = "Hello, World!";
            Console.WriteLine(hello.Replace("Hello", "Greetings"));

            string names = "Adam, Paul, Marie, Hanna, Jack, Bean";
            Console.WriteLine(names.Contains("Adam"));
            Console.WriteLine(names.Contains("Sam"));
            Console.WriteLine(names.Contains("Jack"));
        }
    }
}
