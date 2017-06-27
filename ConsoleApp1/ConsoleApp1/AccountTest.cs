// Figure 4.1: AccountTest.cs
// Creating adnd Manipulating an Account Object


using System;

class AccountTest // Create a class
{ //Open Accounttest class
   static void Main() // Create Main method
   { // Open Main
      // Create an Account object and assign it to myAccount
      Account myAccount = new Account();

      // Display myAccount's initial name (there isn't one)
      Console.WriteLine($"Initial name is: { myAccount.GetName()}");

      // Prompt for and read the name, then put the name in the object
      Console.Write("Enter the name:"); // Prompt
      string theName = Console.ReadLine(); // Read the name
      myAccount.SetName(theName); // Put theName into the myAccount object

      // Display the name stored in the myAccount object
      Console.WriteLine($"myAccount's name is: [myAccount.GetName()}");

   } // Close Main
} // Close AccountTest Class

//using System;

//class AccountTest // Create class
//{
//   static void Main() // Main method
//   {
//      Account myAccount = new Account(); // Instantiate new object from Account class and reference it with myAccount variable of Account type
//      Console.WriteLine($"Initial name is: {myAccount.GetName()}"); // Use GetName method of Account class to show empty name
//      Console.Write("Enter the name: "); // Prompt for input of name
//      string theName = Console.ReadLine(); // Grab input as a string variable
//      myAccount.SetName(theName); // Use Account method SetName to put variable value into name of object
//      Console.WriteLine($"myAccount's name is {myAccount.GetName()}"); // Use GetName method of class Account to show the new name
//   }
//}


