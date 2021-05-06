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
      string word = "hi";
      int answer = 4;
      //act
      int result = CheckScore(word);
      //assert
      Assert.AreEqual(answer,result);
    }
  }
}