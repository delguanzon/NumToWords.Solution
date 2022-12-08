using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumToWords.Models;

namespace NumToWords.Tests
{
  [TestClass]
  public class NumberWordsTests
  {
    [TestMethod]
    public void NumberWordsConstructor_CreateInstanceOfNumberWords_NumberWords()
    {
      NumberWords numToWords = new NumberWords(123);
      Assert.AreEqual(typeof(NumberWords), numToWords.GetType());
    }

    [TestMethod]
    public void NumberWordsConstructor_GetUserInputAndAssignToField_Int() {
      int userInput = 123;
      NumberWords numToWords = new NumberWords(userInput);
      Assert.AreEqual(userInput, numToWords.Number);
    }

  }
}