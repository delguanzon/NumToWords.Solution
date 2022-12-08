using System.Collections.Generic;

namespace NumToWords.Models
{
  public class NumberWords
  {

    private string[] _singleWords = {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};

    private Dictionary<int,string> _doubleWords = new Dictionary<int, string>() { 
      {2, "Twenty"}, 
      {3, "Thirty"}, 
      {4, "Forty"}, 
      {5, "Fifty"}, 
      {6, "Sixty"}, 
      {7, "Sevety"}, 
      {8, "Eighty"},       
      {9, "Ninety"}
    };

    public int Number { get; }
    public NumberWords(int userInput) {
      Number = userInput;
    }

    public string ToWord(){

      string word = "";
      if(Number < 20) {
        word = _singleWords[Number];
      }
      else if (Number > 20 && Number < 99)
      {
        word = _doubleWords[Number/10] + " " + ((Number % 10 == 0) ? "" : _singleWords[Number%10]);
      }
      else if (Number < 1000)
      {
        word = _singleWords[Number/100] + " hundred " + _doubleWords[(Number % 100) / 10] + " " + ((Number % 10 == 0) ? "" : _singleWords[Number%10]);
      }
      return word.ToLower();
    }
  }
}