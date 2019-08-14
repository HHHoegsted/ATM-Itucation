using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Machine
{
    class Program
    {
        
        private void ShowPinCheck()
        {
            int accountEntered;
            string pinEntered;
            Console.WriteLine("Welcome to the ATM, enter your account number");
            Console.Write("> ");
            int.TryParse(Console.ReadLine(), out accountEntered);
            Console.WriteLine("Enter your PIN");
            pinEntered = Console.ReadLine();
        }

        private void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("---------- Welcome to the ATM ----------");
            Console.WriteLine("Would you like to");
            Console.WriteLine("1. Withdraw");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Show Balance");
        }

        

        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.accounts.Add(new Account("Hans-Henrik Høgsted"));
            Console.ReadKey();
            bank.accounts.Add(new Account("Sara Müller", 5000.00));
            Console.ReadKey();


            
        }
    }
}
