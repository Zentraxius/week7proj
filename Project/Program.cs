using Project;
using System;
using System.Collections.Generic;


class Program
{
  static void Main()
  {
    Console.WriteLine("Hello, welcome to Pierre's Bakery.");
    Console.WriteLine("Bread is $5 a loaf, and has a buy 2 get 1 free deal!");
    Console.WriteLine("Pastries, are only $2 each and have a 3 for $5 deal!");

  }
  private static int BreadPrice(int amount)
  {
    Console.WriteLine("How many loaves of bread would you like to order?");
    string userInput = Console.ReadLine();
    int priceOfBread;
    bool canBeParsed = int.TryParse(userInput, out priceOfBread);

    if (canBeParsed)
    {
      priceOfBread = int.Parse(userInput);
      Bread breadOrder = new Bread(priceOfBread);
      Console.WriteLine("You have ordered: " + userInput + "loaves of bread for a total of " + breadOrder);
      return breadOrder;
    }
    else
    {
      Console.WriteLine("Please enter a number");
    }
  }
}