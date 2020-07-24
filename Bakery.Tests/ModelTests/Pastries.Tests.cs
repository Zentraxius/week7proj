using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
// Pastries are $2 for 1, or $5 for 3
namespace Bakery.Tests
{
  [TestClass]
  public class PastriesTests
  {
    [TestMethod] // Are pastries real
    public void PastriesChecker_TestShouldTellIfPastriesExists_PastriesIsReal()
    {
      Pastries pastriesTest = new Pastries(600);
      Assert.AreEqual(typeof(Pastries), pastriesTest.GetType());
    }
    [TestMethod] // How many pastries?
    public void PastriesChecker_TestShouldTellNumberOfPastries_PastriesHasNumber()
    {
      Pastries pastriesTest = new Pastries(30);
      Assert.AreEqual(30, pastriesTest.AmountOfPastries);
    }
    [TestMethod] // What are their price?
    public void PastriesPricer_TestShouldTellPriceOfPastries_PastriesHavePrice()
    {
      Pastries pastriesTest = new Pastries(32);
      Assert.AreEqual(54, pastriesTest.Price());
    }
  }
}