using System.Collections.Generic;

namespace ScrabbleScore.Models
{
  public class Scrabble
  {
    public char[] SplitUserWord(string word)
    {
      char[] array = word.ToLower().ToCharArray();
      return array;
    }

    public int LetterScore(string letter)
    {
      if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u" || letter == "l" || letter == "n" || letter == "r" || letter == "s" || letter == "t")
      {
        return 1;
      }
      else if (letter == "d" || letter == "g")
      {
        return 2;
      }
      else if (letter == "b" || letter == "c" || letter == "m" || letter == "p")
      {
        return 3;
      }
      else if (letter == "f" || letter == "h" || letter == "v" || letter == "w" || letter == "y")
      {
        return 4;
      }
      else if (letter == "k")
      {
        return 5;
      }
      else if (letter == "j" || letter == "x")
      {
        return 8;
      }
      else if (letter == "q" || letter == "z")
      {
        return 10;
      }
      else
      {
        return 0;
      }
    }

    public int ArrayScore(string word)
    {
      return 0;
    }
  }
}