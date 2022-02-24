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
    
    
  }
}
