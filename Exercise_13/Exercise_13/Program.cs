using System;
using System.Globalization;

namespace Exercise_13 {
    class Program {
        static void Main(string[] args) {

            string[] values = Console.ReadLine().Split(' ');
            int code = int.Parse(values[0]);
            int quantity = int.Parse(values[1]);

            double total;
            if (code == 1) {
                total = quantity * 4.0;
            }
            else if (code == 2) {
                total = quantity * 4.5;
            }
            else if (code == 3) {
                total = quantity * 5.0;
            }
            else if (code == 4) {
                total = quantity * 2.0;
            }
            else {
                total = quantity * 1.5;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}