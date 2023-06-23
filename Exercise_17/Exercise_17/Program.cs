using System;

namespace Exercise_17 {
    class Program {
        static void Main(string[] args) {

            int password = int.Parse(Console.ReadLine());

            while (password != 2002) {
                Console.WriteLine("Invalid Password");
                password = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Access Granted");
        }
    }
}