using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop5
{
    internal class BankAccount
    {
        private string accountNumber;
        private double balance;

        public string AccountNumber
        {
            get
            {
                return accountNumber;
            }
        }

        public double Balance
        {
            get
            {
                return balance;
            }
            private set
            {
                if (value > 0)
                {
                    balance = value;
                }
            }
        }

        // Constructor to set account number and initial balance
        public BankAccount(string accNum, double initialBalance)
        {
            accountNumber = accNum;
            Balance = initialBalance; // will use the property validation
        }

        // Deposit Method
        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be greater than 0.");
                return;
            }

            balance += amount;
            Console.WriteLine($"Successfully deposited: {amount}");
        }

        // Withdraw Method
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be greater than 0.");
                return;
            }
            if (amount > balance)
            {
                Console.WriteLine("Insufficient funds for this withdrawal.");
                return;
            }
            balance -= amount;
            Console.WriteLine($"Successfully withdrew: {amount}");
        }
    }
}
