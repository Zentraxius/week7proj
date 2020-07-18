// Pastries are $2 for 1, and $5 for 3
namespace Project
{
  public class Pastries
  {
    public int AmountOfPastries { get; set; }
    public Pastries(int amountOfPastries)
    {
      AmountOfPastries = amountOfPastries;
    }

    public int Price()
    {
      int price = 0;
      int numberOfPastries = AmountOfPastries;
      int remainingPastries = 0;
      int pastriesHolder = 0;

      if (numberOfPastries >= 3)
      {
        remainingPastries = numberOfPastries % 3;
        pastriesHolder = numberOfPastries - remainingPastries;
        price += (pastriesHolder * 5) + (remainingPastries * 2);
      }
      else
      {
        price += numberOfPastries * 2;
      }

      return price;
    }
  }
}
