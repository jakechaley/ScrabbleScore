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
      List<string> letters = new List<string> { "d", "o", "g"};
      Assert.AreEqual(newWord.SplitUserWord("Dog"), letters[0]);
    }
    
    
  }
}
