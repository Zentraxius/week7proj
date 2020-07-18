using System;
// Bread is $5 for 1, buy 2 get 1 free.
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
      int breadHolder = 0;

      if (numberOfBread >= 3)
      {
        remainingBread = numberOfBread % 3;
        breadHolder = numberOfBread - remainingBread;
        price += ((breadHolder / 3) * 10) + (remainingBread * 5);
      }
      else
      {
        price += numberOfBread * 5;
      }
      return price;
    }
  }
}
