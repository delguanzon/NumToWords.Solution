using System;
using System.Collections.Generic;
using NumToWords.Models;

namespace NumToWords
{
  public class Program
  {

    public static void Main()
    {
      Console.WriteLine("Enter a number: ");
      int userInput = int.Parse(Console.ReadLine());
      NumberWords number = new NumberWords(userInput);
      Console.WriteLine("'{0}' is the word equivalent of {1}.", number.ToWord(), userInput);
    }
  }
}