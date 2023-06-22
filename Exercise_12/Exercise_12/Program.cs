using System;

namespace Exercise_12 {
    class Program {
        static void Main(string[] args) {

            string[] values = Console.ReadLine().Split(' ');
            int initialHour = int.Parse(values[0]);
            int finalHour = int.Parse(values[1]);

            int duration;
            if (initialHour < finalHour) {
                duration = finalHour - initialHour;
            }
            else {
                duration = 24 - initialHour + finalHour;
            }

            Console.WriteLine("THE GAME LASTED " + duration + " HOURS");
        }
    }
}