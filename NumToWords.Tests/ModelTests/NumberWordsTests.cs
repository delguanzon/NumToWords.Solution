using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumToWords;

namespace NumToWords.Tests
{
  [TestClass]
  public class ClassNameTests
  {
    [TestMethod]
    public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      Assert.AreEqual(true, 1==1);
    }

  }
}