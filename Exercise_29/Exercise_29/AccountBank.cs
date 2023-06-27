using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_29 {
    internal class AccountBank {

        public int Number { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }

        public AccountBank(int number, string holder) {
            Number = number;
            Holder = holder;
        }

        public AccountBank(int number, string holder, double balance) : this(number, holder) {
            Balance = balance;
        }

        public void Deposit(double quantity) {
           Balance += quantity;
        }

        public void Withdraw(double quantity) {
            Balance -= quantity + 5.0;
        }

        public override string ToString() {
            return "Account "
                + Number
                + ", Holder: "
                + Holder
                + ", Balance: $ "
                + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
