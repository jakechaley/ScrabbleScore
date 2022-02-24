using System;
using System.Collections.Generic;
using ScrabbleScore.Models;

namespace ScrabbleInterface
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Scrabble Score. Enter a word to find out that word's value in Scrabble.");
      Scrabble newWord = new Scrabble();
      Console.WriteLine(newWord.WordScore(Console.ReadLine()).ToString());
      Console.WriteLine("Would you like to check another word? \"Press 'Y' for yes. Press 'ENTER' to exit program");
      string UserInput = Console.ReadLine();
      if (UserInput == "Y" || UserInput == "y")
      {
        Main();
      }
      else
      {
        Console.WriteLine("Goodbye!");
      }

      
      
    }
  }
}