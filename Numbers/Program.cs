using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 14;
            int b = 12;
            int c;

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

            c = a + b;
            Console.WriteLine($"a + b = {c}");

            c = a - b;
            Console.WriteLine($"a - b = {c}");

            c = a * b;
            Console.WriteLine($"a * b = {c}");

            c = a / b;
            Console.WriteLine($"a / b = {c}");

            Console.WriteLine(12 + 14 / 7 - 3 * 2);

            Console.WriteLine($"a % b = {a % b}");

            double m = a;
            double n = b;

            Console.WriteLine($"m / n = {m / n}");

            decimal x = a;
            decimal y = b;

            Console.WriteLine($"x / y = {x / y}");

            Console.WriteLine($"PI = {Math.PI}");

            double radius = 2.5;
            double area = Math.PI * radius * radius;
            Console.WriteLine($"Area of Circle of Radius {radius} units is {area} sq. units.");
        }
    }
}
