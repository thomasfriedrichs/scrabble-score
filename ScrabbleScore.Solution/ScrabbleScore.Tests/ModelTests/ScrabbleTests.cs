using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Scrabble.ScrabbleScore;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScrabbleScoreTests
  {
    [TestMethod]
    public void CheckScore_returnSum_Integer()
    {
      //arrange
      string word = "qqq";
      int score = 30;
      //act
      int result = CheckScore(word);
      //assert
      Assert.AreEqual(score,result);
    }
  }
} 