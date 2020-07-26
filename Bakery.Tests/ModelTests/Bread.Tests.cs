using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
// Bread is $5 a loaf, buy 2 get 1 free
namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests

  {
    [TestMethod] // Is bread real
    public void BreadChecker_TestShouldTellIfBreadExists_BreadIsReal()
    {
      Bread breadTest = new Bread(600);
      Assert.AreEqual(typeof(Bread), breadTest.GetType());
    }

    [TestMethod] // What is bread amount
    public void BreadNumber_DoesBreadReturnNumber_BreadHasNumber()
    {
      Bread breadTest = new Bread(25);
      Assert.AreEqual(25, breadTest.AmountOfBread);
    }
    [TestMethod] // What is bread price

    public void BreadPrice_WhatIsPriceOfBread_BreadHasPrice()
    {
      Bread breadTest = new Bread(25);
      Assert.AreEqual(85, breadTest.Price());
    }
    [TestMethod] // Discount Free Price
    public void BreadPrice2_WhatIsDiscountFreePrice_BreadIsDelicious()
    {
      Bread breadTest = new Bread(2);
      Assert.AreEqual(10, breadTest.Price());
    }
  }
}