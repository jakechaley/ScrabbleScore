using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ScrabbleScore.Models;
using System;

namespace ScrabbleScore.TestTools
{
  [TestClass]
  public class ScrabbleScoreTests
  {
    [TestMethod]
    public void SplitUserWord_SplitUserWordIntoArray_String()
    {
      Scrabble newWord = new Scrabble();
      char[] letters = {'d', 'o', 'g'};
      char[] result = newWord.SplitUserWord("Dog");
      Assert.AreEqual(letters[0], result[0]);
      Assert.AreEqual(letters[1], result[1]);
      Assert.AreEqual(letters[2], result[2]);
    }
    
    [TestMethod]
    public void LetterScore_FindTheScoreOfALetter_Int()
    {
      Scrabble newWord = new Scrabble();
      Assert.AreEqual(newWord.LetterScore("o"), 1);
      Assert.AreEqual(newWord.LetterScore("d"), 2);
      Assert.AreEqual(newWord.LetterScore("b"), 3);
      Assert.AreEqual(newWord.LetterScore("f"), 4);
      Assert.AreEqual(newWord.LetterScore("k"), 5);
      Assert.AreEqual(newWord.LetterScore("j"), 8);
      Assert.AreEqual(newWord.LetterScore("q"), 10);
    }

    [TestMethod]
    public void ArrayScore_FindTheScrabbleScoreOfWord_Int()
    {
      Scrabble newWord = new Scrabble();
      Assert.AreEqual(4, newWord.ArrayScore("dog"));
    }
    
  }
}
