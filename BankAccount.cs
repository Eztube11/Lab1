using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class BankAccount
    {
        private int id;
        private decimal balance = 0;
        public int Id;
        public decimal Balance = 0;
        public BankAccount(int id, decimal balance)
        {
            this.id = id;
            this.balance = balance;
        }
        public void Print()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Balance: " + balance);
        }
        public void Deposit(decimal deposit)
        {
            balance = balance + deposit;
            Console.WriteLine("Sent: " + deposit);
            Console.WriteLine("Current amount in the account: " + balance);
        }
        public void Withdraw(decimal withdraw)
        {
            balance = balance - withdraw;
            Console.WriteLine("Withdraw: " + withdraw);
            Console.WriteLine("Current amount in the account: " + balance);
            if (!IsAccountEmpty())
            {
                balance = 0;
                Console.WriteLine("Your Account is Empty");
            }
        }
        public bool IsAccountEmpty()
        {
            return balance >= 0;
        }
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount(1, 15);
            //acc.Id = 1;
            //acc.Balance = 15;
            //Console.WriteLine($"Id {acc.Id}, balance {acc.Balance}");
            //Console.ReadLine();
            acc.Print();
            acc.Deposit(15);
            acc.Withdraw(10);
            Console.ReadLine();
        }
    }
}