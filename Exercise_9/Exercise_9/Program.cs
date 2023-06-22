using System;

namespace Exercise_9
{
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Is this number negative?");
            int number = int.Parse(Console.ReadLine());

            if (number < 0) {
                Console.WriteLine("Negative!");
            }
            else
            {
                Console.WriteLine("Not Negative!");
            }
        }
    }
}