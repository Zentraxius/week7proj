using System;

namespace Project
{
  public class Bread
  {
    public int AmountOfBread { get; set; }
    public Bread(int amountOfBread)
    {
      AmountOfBread = amountOfBread;
    }

    public int Price()
    {
      int price = 0;
      int numberOfBread = AmountOfBread;
      int remainingBread = 0;
      remainingBread = numberOfBread % 3;
      price += (numberOfBread - remainingBread) * 10 + (remainingBread * 5);
      return price;

      // if (numberOfBread % 3 == 0)
      // {
      //   price += numberOfBread * 10;
      // }
      // price += numberOfBread * 5;
      // return price;
    }
  }
}
