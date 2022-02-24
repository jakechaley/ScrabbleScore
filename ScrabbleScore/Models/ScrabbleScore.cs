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
      return 0;
    }
  }
  
}