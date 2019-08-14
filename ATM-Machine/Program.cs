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
            Account ac = new Account("Hans-Henrik Høgsted");
            Console.ReadKey();
            Account ac2 = new Account("Sara Müller", 5000.00);
            Console.ReadKey();

            
        }
    }
}
