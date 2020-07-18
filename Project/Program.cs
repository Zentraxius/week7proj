using System;
using Project;
using System.Collections.Generic;

namespace Project
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Hello, welcome to Pierre's Bakery.");
      Console.WriteLine("Bread is $5 a loaf, and has a buy 2 get 1 free deal!");
      Console.WriteLine("Pastries, are only $2 each and have a 3 for $5 deal!");
      Console.WriteLine("-----------------------------------------------------");
      Console.WriteLine("How many loaves of bread would you like?");

    }
    // private static int BreadPrice(int amount)
    // {
    //   Console.WriteLine("How many loaves of bread would you like?");
    //   string userInputBread = Console.ReadLine();
    //   int priceOfBread;

    //   bool canBeParsed = int.TryParse(userInputBread, out priceOfBread);

    //   if (canBeParsed)
    //   {
    //     int amountToOrderBread = int.Parse(userInputBread);
    //     Bread breadOrder = new Bread(amountToOrderBread);
    //     return breadOrder.Price();
    //   }
    //   else
    //   {
    //     Console.WriteLine("Please enter a valid number");
    //   }
    // }
  }
}
