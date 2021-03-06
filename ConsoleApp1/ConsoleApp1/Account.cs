﻿ Figure 4.2: Account.cs
 A simple Account class that contains a private instance
    variable name and public methods to Set and Get the nbame's value.

class Account // Pascal class notation of the name
{
   private string name; // Instance varibale name belonging to class Account
   // private - Only object will be able to read or manipulate the variable through its methods
   // Keep instance variable declarations in the beginning out of convention
   // Each instance variable will have a default value based on its type (null for strings), or
   //    can set defaults.

   // Method that sets the account name in the object
   public void SetName(string accountName) // usable by method client, with no return, and a parameter
   {
      name = accountName; // store the account name in the instance variable of the class
   }

   // Method retrieves acccount name from the object
   public string GetName()
   // public, so usable outside the class
   {
      return name; // Returns name's vlaue to method's caller
      // Not void since it will return a value
   }

}

//class Account
//{
//   private string name;
//   public void SetName(string accountName)
//   {
//      name = accountName;
//   }
//   public string GetName()
//   {
//      return name;
//   }
//}