/*
 * https://coderbyte.com/editor/Letter%20Changes:Csharp
 * 
 * 
 * Using the C# language, have the function LetterChanges(str) 
 * take the str parameter being passed and modify it using the following  
 * algorithm. Replace every letter in the string with the letter following 
 * it in the alphabet (ie. c becomes d, z becomes a). Then capitalize every 
 * vowel in this new string (a, e, i, o, u) and finally return this modified string. 
*/

using System;
namespace DailyChallenges.CoderByte
{
    public class LetterChanges1
    {
        public static string LetterChanges(string str)
        {

            var returnedStr = string.Empty;
            var strToCharArray = str.ToCharArray();

            foreach (char c in strToCharArray)
            {

                var newChar = ' ';
                if (!Char.IsLetter(c))
                    newChar = c;
                else if (c == 'z')
                    newChar = 'a';
                else if (c == 'Z')
                    newChar = 'A';
                else
                    newChar = (char)(((int)c) + 1);

                if (newChar == 'a' || newChar == 'e' || newChar == 'i' || newChar == 'o' || newChar == 'u')
                    returnedStr = String.Concat(returnedStr, Char.ToUpper(newChar));
                else
                    returnedStr = String.Concat(returnedStr, newChar);
                //Console.WriteLine("returnedStr: " + returnedStr);

            }

            return returnedStr;
        }

        //static void Main() 
        //{
        //    Console.WriteLine(LetterChanges(Console.ReadLine()));
        //}
    }
}
