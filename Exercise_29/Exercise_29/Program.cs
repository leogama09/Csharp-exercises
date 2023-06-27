using System;
using System.Globalization;

namespace Exercise_29 {
    class Program {
        static void Main(string[] args) {

            AccountBank account;

            Console.Write("Enter the account number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter the account holder: ");
            string holder = Console.ReadLine();
            Console.Write("There will be initial deposit (y/n)? ");
            char ans = char.Parse(Console.ReadLine());
            if (ans == 'y' || ans == 'Y') {
                Console.Write("Enter the initial deposit amount: ");
                double initialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account = new AccountBank(number, holder, initialDeposit);
            }
            else {
                account = new AccountBank(number, holder);
            }

            Console.WriteLine();
            Console.WriteLine("Account data:");
            Console.WriteLine(account);

            Console.WriteLine();
            Console.Write("Enter a deposit amount: ");
            double quantity = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Deposit(quantity);
            Console.WriteLine("Updated account details:");
            Console.WriteLine(account);

            Console.WriteLine();
            Console.Write("Enter a withdrawal amount: ");
            quantity = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Withdraw(quantity);
            Console.WriteLine("Updated account details:");
            Console.WriteLine(account);
        }
    }
}