using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Machine
{
    class Account
    {
        Random r = new Random();
        private static int numberOfAccounts = 0;
        private int accountNumber;
        private string accountOwner;
        private double balance;
        private string PIN;

        public int GetAccountNumber()
        {
            return accountNumber;
        }

        public string GetPinNumber()
        {
            return PIN;
        }

        public Account(string accountOwner)
        {
            this.accountNumber = ++numberOfAccounts;
            this.accountOwner = accountOwner;
            this.balance = 0;
            this.PIN = r.Next(9999).ToString("0000");
            Console.WriteLine($"PIN Number for account {accountNumber} is {PIN}");
        }

        public Account(string accountOwner, double balance) : this(accountOwner)
        {
            this.balance = balance;
        }

        public void Saldo()
        {
            Console.WriteLine($"Balance for account {accountNumber} is:\t{this.balance} kr.");
        }

        private bool CheckAmount(int amount)
        {
            return amount % 50 == 0;
        }

        public void Deposit(int amount)
        {
            if (!CheckAmount(amount))
            {
                Console.WriteLine("Impossible, must be divisible by 50");
            }
            else
            {
                this.balance += amount;
                Console.WriteLine($"You have deposited {amount}, balance is {balance}");
            }
            
        }

        public void Withdraw(int amount)
        {
            if (balance < amount)
            {
                Console.WriteLine($"Insufficient funds in account {accountNumber}");
            }
            else if (!CheckAmount(amount))
            {
                Console.WriteLine("Impossible, must be divisible by 50");
            } else
            {
                balance -= amount;
                Console.WriteLine($"You have withdrawn {amount}, balance is {balance}");
            }
        }
    }
}
