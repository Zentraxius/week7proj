using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project;
//Bread is $5 a loaf, buy 2 get 1 free
namespace Project.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadChecker_TestShouldTellPrice_BreadIs5()
    {
      Bread breadTest = new Bread(600);
      Assert.AreEqual(typeof(Bread), breadTest.GetType());
    }
  }
}