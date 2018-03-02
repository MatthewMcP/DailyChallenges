/* https://coderbyte.com/editor/Simple%20Symbols:Csharp
 * 
 * Using the C# language, have the function SimpleSymbols(str) take the str 
 * parameter being passed and determine if it is an acceptable sequence by 
 * either returning the string true or false. The str parameter will be 
 * composed of + and = symbols with several letters between them (ie.
 * ++d+===+c++==a) and for the string to be true each letter must be 
 * surrounded by a + symbol. So the string to the left would be false. 
 * The string will not be empty and will have at least one letter. 
 */

using System;
namespace DailyChallenges.CoderByte
{
    public class SimpleSymbols1
    {

        public static string SimpleSymbols(string str)
        {
            for (int i =0; i < str.Length; i++)
            {
                char c = str[i];

                if (!Char.IsLetter(c))
                {
                    continue;
                }

                //if start with letter or end with letter
                if (i == 0 || i == str.Length-1)
                {
                    return "false";
                }

                if (str[i-1] != '+' || str[i+1] != '+')
                {
                    return "false";
                }

            }

            return "true";
        }

        //static void Main()
        //{
        //    Console.WriteLine(SimpleSymbols(Console.ReadLine()));
        //}
    }
}
