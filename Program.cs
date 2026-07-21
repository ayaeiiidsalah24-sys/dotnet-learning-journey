using Microsoft.VisualBasic;
using OOP;

#region Person examples
//Person person = new Person();
//person.FirstName = "John";
//person.LastName = "hgdi";
////person.>> just invoke the properties and methods of the Person class here not the variables.


////person.mobileNumber??
////because it's by default private, you cannot access it directly from outside the class. You can only access the public properties and methods of the Person class. If you want to set or get the mobile number, you would need to create a public property for it in the Person class, similar to how FirstName and LastName are implemented. or make the variable public, but that is not recommended as it breaks encapsulation. 
//person.moblieNumber = "123-456-7890"; // This will work because moblieNumber is public, but it's better to use a property for encapsulation.
//person.DateOfBirth = new DateOnly(1990, 1, 1);
//person.Country = "USA";

//Console.WriteLine(person.FirstName);



//Person person2 = new Person();
//person2.FirstName = "Jane";
//person2.LastName = "Doe";
//person2.Country = "uk"; 
//person2.DateOfBirth = new DateOnly(1995, 5, 15);
//person2.moblieNumber = "987-654-3210"; // This will work because moblieNumber is public, but it's better to use a property for encapsulation.

//Console.WriteLine(person2.FirstName); 
#endregion



BankAccount  myAccount = new BankAccount();
myAccount.BankName = "Cairo Bank";
myAccount.BranchName = "Giza";
myAccount.BranchAddress = "124 maadi";
myAccount.AccountNumber = "DE0208497";
myAccount.AccounCurrency = "USD";
myAccount.Balance = 1500;
Console.WriteLine(myAccount.BankName);
Console.WriteLine(myAccount.Balance);


//myAccount.withdraw(1750)
//myAccount.withdraw(250)


myAccount.Deposit(500);






