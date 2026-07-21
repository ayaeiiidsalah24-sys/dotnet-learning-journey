using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class BankAccount
    {

        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string BranchAddress { get; set; }
        public string AccountNumber { get; set; }
        public string AccounCurrency { get; set; }
        public decimal Balance { get; set; }

        public void withdraw(decimal Amount)
        {
            decimal newBalance = Balance - Amount;
            Console.WriteLine($"withdraw amount is {Amount}");
            if (newBalance < 0)
            {
                Console.WriteLine("Invalid Transaction");
            }
            else {

                Console.WriteLine($" Your new balance for {AccountNumber}  is {newBalance}");
            }

            Console.WriteLine($"Transaction Date {DateTime.Now}");

        }
        public void Deposit(decimal Amount)
        {
            decimal newBalance = Balance + Amount;
            Console.WriteLine($"Deposit amount is {Amount}");
       
            Console.WriteLine($" Your new balance for {AccountNumber}  is {newBalance}");
            Console.WriteLine($"Transaction Date {DateTime.Now}");








        }

        public void Transfer() { }
        public void ChangePassword() { }
        public void CreateSubAccount() { }
        public void PrintSatement() { }

       
    }
}
