using System;
using System.Globalization;

namespace Exercise_14 {
    class Program {
        static void Main(string[] args) {

            double number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (number < 0.0 || number > 100.0) {
                Console.WriteLine("Out of range");
            }
            else if (number <= 25.0) {
                Console.WriteLine("Range [0,25]");
            }
            else if (number <= 50.0) {
                Console.WriteLine("Range (25,50]");
            }
            else if (number <= 75.0) {
                Console.WriteLine("Range (50,75]");
            }
            else {
                Console.WriteLine("Range (75,100]");
            }
        }
    }
}