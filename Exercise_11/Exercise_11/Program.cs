using System;

namespace Exercise_11
{
    internal class Program {
        static void Main(string[] args) {
            string[] values = Console.ReadLine().Split(' ');
            int A = int.Parse(values[0]);
            int B = int.Parse(values[1]);

            if (A % B == 0 || B % A == 0) {
                Console.WriteLine("Are multiples");
            }
            else {
                Console.WriteLine("Are not multiples");
            }
        }
    }
}