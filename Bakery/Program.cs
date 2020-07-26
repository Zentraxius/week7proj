using System;
using Bakery.Models;
using System.Collections.Generic;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      int totalPrice = 0;
      Console.WriteLine("Hello, welcome to Pierre's Bakery.");
      Console.WriteLine("Bread is $5 a loaf, and has a buy 2 get 1 free deal!");
      Console.WriteLine("Pastries, are only $2 each and have a 3 for $5 deal!");
      Console.WriteLine(" ▄▄▄·▪  ▄▄▄ .▄▄▄  ▄▄▄  ▄▄▄ ..▄▄ ");
      Console.WriteLine("▐█ ▄███ ▀▄.▀·▀▄ █·▀▄ █·▀▄.▀·▐█ ▀.");
      Console.WriteLine(" ██▀·▐█·▐▀▀▪▄▐▀▀▄ ▐▀▀▄ ▐▀▀▪▄▄▀▀▀█");
      Console.WriteLine("▐█▪·•▐█▌▐█▄▄▌▐█•█▌▐█•█▌▐█▄▄▌▐█▄▪▐█");
      Console.WriteLine(".▀   ▀▀▀ ▀▀▀ .▀  ▀.▀  ▀ ▀▀▀  ▀▀▀▀");
      Console.WriteLine("How many loaves of bread would you like?");
      string breadOrdered = Console.ReadLine();
      int priceOfBread;
      bool canOrderBread = int.TryParse(breadOrdered, out priceOfBread);

      if (canOrderBread && int.Parse(breadOrdered) >= 1)
      {
        int breadToOrder = int.Parse(breadOrdered);
        Bread breadOrder = new Bread(breadToOrder);
        Console.WriteLine("That will be: $" + breadOrder.Price() + " for the bread.");
        totalPrice += breadOrder.Price();
      }
      else
      {
        Console.WriteLine("Please enter a valid number.");
      }
      Console.WriteLine("How many pastries would you like?");
      string pastriesOrdered = Console.ReadLine();
      int priceOfPastries;
      bool canOrderPastries = int.TryParse(pastriesOrdered, out priceOfPastries);

      if (canOrderPastries && int.Parse(pastriesOrdered) >= 1)
      {
        int pastriesToOrder = int.Parse(pastriesOrdered);
        Pastries pastriesOrder = new Pastries(pastriesToOrder);
        Console.WriteLine("That will be: $" + pastriesOrder.Price() + " for the pastries.");
        totalPrice += pastriesOrder.Price();
      }
      else
      {
        Console.WriteLine("Please enter a valid number.");
      }
      Console.WriteLine("Your total today comes to: $" + totalPrice);
      Console.WriteLine("Will that be all for you today? Y/N");
      string userResponse = Console.ReadLine();
      if (userResponse == "N")
      {
        Main();
      }
      else
      {
        Console.WriteLine("Goodbye!");
      }
    }
  }
}
