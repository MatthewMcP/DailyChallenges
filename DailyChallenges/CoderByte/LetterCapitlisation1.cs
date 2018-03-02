/*https://coderbyte.com/editor/Letter%20Capitalize:Csharp
 * 
 * Using the C# language, have the function LetterCapitalize(str) take the str
 * parameter being passed and capitalize the first letter of each word. 
 * Words will be separated by only one space. 
 */

using System;
namespace DailyChallenges
{
    public class LetterCapitlisation1
    {
        public static string LetterCapitalize(string str)
        {
            var result = string.Empty;
            string[] wordArray = str.Split();

            foreach (string word in wordArray)
            {
                var firstLetter = char.ToUpper(word[0]);
                var restOfWork = word.Substring(1, word.Length - 1);

                result = String.Concat(result, firstLetter, restOfWork, ' ');
            }

            Console.WriteLine("returnedStr: " + result);

            return result;
        }

        //static void Main()
        //{
        //    Console.WriteLine(LetterCapitalize(Console.ReadLine()));
        //}
    }
}
