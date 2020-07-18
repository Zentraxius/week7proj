using System;

namespace Project
{
  public class Bread
  {
    public int AmountOfBread { get; set; }
    public Bread(int amountOfBread)
    {
      amountOfBread = AmountOfBread;
    }

    public int Price()
    {
      int price = 5;
      int numberOfBread = AmountOfBread;

      if (numberOfBread % 3 == 0)
      {

      }
    }
  }
}
