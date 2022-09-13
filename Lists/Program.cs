using System;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<String>{"Anna", "Jasmine"};

            Console.WriteLine($"Initial Count: {names.Count}");

            names.Add("Rosy");
            names.Add("Hanna");
            names.Add("Lily");

            Console.WriteLine($"Current Count: {names.Count}");

            foreach (var name in names)
            {
                Console.WriteLine($"Salut {name}!");
            }

            Console.WriteLine("Element 2: " + names[2]);

            Console.WriteLine($"Index of Element \"Hanna\" is {names.IndexOf("Hanna")}.");
            Console.WriteLine($"Index of Element \"Raven\" is {names.IndexOf("Raven")}.");

            names.Sort();
            Console.Write("{");
            foreach (var name in names)
            {
                Console.Write(name + ", ");
            }
            Console.Write("}\n");
        }
    }
}
