using Microsoft.VisualBasic;
using OOP;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Person examples

            //Person person = new Person();
            //person.FirstName = "John";
            //person.LastName = "hgdi";
            ////person.>> just invoke the properties and methods of the Person class here not the variables.

            ////person.mobileNumber??
            ////because it's by default private, you cannot access it directly from outside the class. You can only access the public properties and methods of the Person class. If you want to set or get the mobile number, you would need to create a public property for it in the Person class, similar to how FirstName and LastName are implemented. or make the variable public, but that is not recommended as it breaks encapsulation.
            //person.moblieNumber = "123-456-7890";
            //person.DateOfBirth = new DateOnly(1990, 1, 1);
            //person.Country = "USA";

            //Console.WriteLine(person.FirstName);

            //Person person2 = new Person();
            //person2.FirstName = "Jane";
            //person2.LastName = "Doe";
            //person2.Country = "uk";
            //person2.DateOfBirth = new DateOnly(1995, 5, 15);
            //person2.moblieNumber = "987-654-3210";

            //Console.WriteLine(person2.FirstName);

            #endregion

            #region BankAccountExamples

            //BankAccount myAccount = new BankAccount();
            //myAccount.BankName = "Cairo Bank";
            //myAccount.BranchName = "Giza";
            //myAccount.BranchAddress = "124 maadi";
            //myAccount.AccountNumber = "DE0208497";
            //myAccount.AccounCurrency = "USD";
            //myAccount.Balance = 1500;

            ////myAccount.withdraw(1750);
            ////myAccount.withdraw(250);

            ////myAccount.Deposit(500);

            //BankAccount myAccount2 = new BankAccount("Masr", "hith", "giza", "htri95984", "USD", 50000);

            //myAccount2.Balance = 500;
            //Console.WriteLine("your current balance is :: " + myAccount2.Balance);
            //myAccount2.withdraw(200);

            #endregion

            

           
        }
    }
}