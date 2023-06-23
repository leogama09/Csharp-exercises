using System;

namespace Exercise_19 {
    class Program {
        static void Main(string[] args) {

            int alcohol = 0;
            int gasoline = 0;
            int diesel = 0;

            int type = int.Parse(Console.ReadLine());

            while (type != 4) {
                if (type == 1) {
                    alcohol++;
                }
                else if (type == 2) {
                    gasoline++;
                }
                else if (type == 3) {
                    diesel++;
                }

                type = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("THANK YOU!");
            Console.WriteLine("Alcohol: " + alcohol);
            Console.WriteLine("Gasoline: " + gasoline);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}