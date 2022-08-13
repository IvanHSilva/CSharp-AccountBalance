using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBalance {
    public class Account {

        // attributes
        public int Number { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }

        // constructors
        public Account(int number, string holder) {
            Number = number;
            Holder = holder;
        }

        public Account(int number, string holder, double deposit) : this(number, holder) {
            Deposit(deposit);
        }

        // methods
        private double tax = 5.0;

        public void Deposit(double amount) {
            Balance += amount;
        }
        
        public void Withdraw(double amount) {
            Balance -= amount + tax;
        }

        // tostring
        public override string ToString() {
            return $"Conta: {Number}, Titular: {Holder}, Saldo: $ {Balance.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
