using System;

namespace Exercise_18 {
    class Program {
        static void Main(string[] args) {

            string[] values = Console.ReadLine().Split(' ');
            int x = int.Parse(values[0]);
            int y = int.Parse(values[1]);

            while (x != 0 && y != 0) {
                if (x > 0 && y > 0) {
                    Console.WriteLine("first");
                }
                else if (x < 0 && y > 0) {
                    Console.WriteLine("second");
                }
                else if (x < 0 && y < 0) {
                    Console.WriteLine("third");
                }
                else {
                    Console.WriteLine("fourth");
                }
                values = Console.ReadLine().Split(' ');
                x = int.Parse(values[0]);
                y = int.Parse(values[1]);
            }
        }
    }
}