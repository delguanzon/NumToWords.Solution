namespace NumToWords.Models
{
  public class NumberWords
  {

    public int Number { get; }
    public NumberWords(int userInput) {
      Number = userInput;
    }

  }
}