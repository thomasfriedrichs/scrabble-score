using System;
using System.Collections.Generic;

namespace Scrabble
{
  public class ScrabbleScore
  {
          public static Dictionary<char, int> letters = new Dictionary<char, int>()
      {
        {'A',1}, {'B',4}, {'C',4}, {'D',2}, {'E',1}, {'F',4}, {'G',3}, {'H',3}, {'I',1}, {'J',10}, {'K',5}, {'L',2}, {'M',4}, {'N',2}, {'O',1}, {'P',4}, {'Q',10}, {'R',1}, {'S',1}, {'T',1}, {'U',2}, {'V',5}, {'W',8}, {'X',8}, {'Y',3}, {'Z',10}
      };

      private static int GetLetterScore(char letter)
    {
      int characterScore = letters[letter];
      return characterScore;
    }
    public static int CheckScore(string word)
    {
      int score = 0;
      string inputWord = word.ToUpper();
      foreach(char letter in inputWord)
      {
        score += GetLetterScore(letter);
      } 
      return score;
    }
  }
}
