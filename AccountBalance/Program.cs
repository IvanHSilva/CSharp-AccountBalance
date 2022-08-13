using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBalance {
    internal class Program {
        static void Main(string[] args) {

            // variables declaration
            Account acc;

            // data solicitation
            Console.Write("Digite o número da conta: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Digite o titular da conta: ");
            string holder= Console.ReadLine();
            Console.Write("Tem depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());

            // Check initial deposit
            if (resp == 's' || resp == 'S') {
                Console.Write("Valor do depósito inicial: ");
                double deposit = double.Parse(Console.ReadLine());
                acc = new Account(number, holder, deposit);
            }
            else {
                acc = new Account(number, holder);
            }


            // Show account data
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(acc);
            Console.WriteLine();

            // Operations
            Console.Write("Valor do Depósito: ");
            double amount = double.Parse(Console.ReadLine());
            acc.Deposit(amount);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(acc);
            Console.WriteLine();

            Console.Write("Valor do Saque: ");
            amount = double.Parse(Console.ReadLine());
            acc.Withdraw(amount);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(acc);
        }
    }
}
