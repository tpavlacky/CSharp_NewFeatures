using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Examples.IndicesAndRanges
{
  //syntactic sugar for System.Index + System.Range 
  internal class Words
  {
    public void Test()
    {
      var words = new string[]
      {
        // index from start    index from end
        "The",      // 0                   ^9
        "quick",    // 1                   ^8
        "brown",    // 2                   ^7
        "fox",      // 3                   ^6
        "jumped",   // 4                   ^5
        "over",     // 5                   ^4
        "the",      // 6                   ^3
        "lazy",     // 7                   ^2
        "dog"       // 8                   ^1
      };              // 9 (or words.Length) ^0

      var lastWord = words[^1]; //dog
		  //public Index (int value, bool fromEnd = false);
		  //string text = words[new Index(1, true).GetOffset(words.Length)];

			var quickBrownFox = words[1..4]; // The quick brown fox
      //string[] subArray = RuntimeHelpers.GetSubArray(words, new Range(1, 4));
      
      var lazyDog = words[^2..^0]; //lazy dog
      //string[] subArray2 = RuntimeHelpers.GetSubArray(words, new Range(new Index(2, true), new Index(0, true)));

      var allWords = words[..]; // contains "The" through "dog".
      //string[] subArray3 = RuntimeHelpers.GetSubArray(words, Range.All);

      var firstPhrase = words[..4]; // contains "The" through "fox"
      //string[] subArray4 = RuntimeHelpers.GetSubArray(words, Range.EndAt(4));

      var lastPhrase = words[6..]; // contains "the", "lazy" and "dog"
      //string[] subArray5 = RuntimeHelpers.GetSubArray(words, Range.StartAt(6));

      Range phrase = 1..4;
      var text = words[phrase];
      //Range range = new Range(1, 4);
      //string[] subArray6 = RuntimeHelpers.GetSubArray(words, range);

    }
  }
}
