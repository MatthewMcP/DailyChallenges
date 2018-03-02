/* https://coderbyte.com/editor/Alphabet%20Soup:Csharp
 * 
 * Using the C# language, have the function AlphabetSoup(str) take the str
 * string parameter being passed and return the string with the letters in 
 * alphabetical order (ie. hello becomes ehllo). Assume numbers and punctuation 
 * symbols will not be included in the string. 
 */

using System;
using System.Linq;
namespace DailyChallenges.CoderByte
{
    public class AlphabetSoup1
    {
        public static string AlphabetSoup(string str)
        {
            return String.Concat(str.OrderBy(c => c));
        }

        //static void Main()
        //{
        //    Console.WriteLine(AlphabetSoup(Console.ReadLine()));
        //}
    }
}
