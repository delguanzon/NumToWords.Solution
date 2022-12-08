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

    [TestMethod]
    public void ToWord_ReturnNumberWordEquivalentForSingleDigits_String() {
      int userInput = 3;
      NumberWords number = new NumberWords(userInput);
      Assert.AreEqual("three", number.ToWord());
    }

    [TestMethod]
    public void ToWord_ReturnNumberWordEquivalentForDigitsStartingFromTenToNineteen_String() {
      int userInput = 19;
      NumberWords number = new NumberWords(userInput);
      Assert.AreEqual("nineteen", number.ToWord());
    }

    [TestMethod]
    public void ToWord_ReturnNumberWordEquivalentForDoubleDigitsGreaterThanNineteen_String() {
      int userInput = 21;
      NumberWords number = new NumberWords(userInput);
      Assert.AreEqual("twenty one", number.ToWord());
    }

    
  }
}