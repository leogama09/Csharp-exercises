using System;

namespace Exercise_10
{
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Is this number odd or even?");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0) {
                Console.WriteLine("Even!");
            } else {
                Console.WriteLine("Odd!");
            }
        }
    }
}