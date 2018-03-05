/* https://coderbyte.com/editor/Longest%20Word:Csharp
 * 
 * Using the C# language, have the function LongestWord(sen) take the sen 
 * parameter being passed and return the largest word in the string. If there 
 * are two or more words that are the same length, return the first word from 
 * the string with that length. Ignore punctuation and assume sen will
 * not be empty. 
 */

using System;
namespace DailyChallenges.CoderByte
{
    public class LongestWord1
    {
        public static string LongestWord(string sen)
        {
            var words = sen.Split(' ');

            var longestWord = string.Empty;
            var letterCount = 0;
            foreach (var word in words)
            {
                if(word.Length > letterCount)
                {
                    letterCount = word.Length;
                    longestWord = word;
                }
            }

            return longestWord;
        }

        //static void Main()
        //{
        //    Console.WriteLine(LongestWord(Console.ReadLine()));
        //}
    }
}
