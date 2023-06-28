﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Exercise_30 {
    class Program {
        static void Main(string[] args) {

            Student[] vect = new Student[10];
            
            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {

                Console.WriteLine();
                Console.WriteLine($"Rent #(i):");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Bedrooms: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Student(name, email);
            }

            Console.WriteLine();
            Console.WriteLine("Occupied Rooms: ");
            for (int i = 0; i < 10; i++) {
                if (vect[i] != null) {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}