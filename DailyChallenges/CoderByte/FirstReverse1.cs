/* https://coderbyte.com/editor/First%20Reverse:Csharp
 * 
 * 
 * Using the C# language, have the function FirstReverse(str) take the str 
 * parameter being passed and return the string in reversed order. 
 * For example: if the input string is "Hello World and Coders" then your 
 * program should return the string sredoC dna dlroW olleH. 
 * 
 * */

using System;
namespace DailyChallenges
{
    public class FirstReverse1
    {
        public static string FirstReverse(string str)
        {
            string reverservedStr = string.Empty;
            var charArray = str.ToCharArray();

            for (int i = 1; i < str.Length; i++)
            {
                reverservedStr = String.Concat(reverservedStr, charArray[str.Length - i]);
                //Console.WriteLine("IreverservedStr: " + reverservedStr);
            }

            reverservedStr = String.Concat(reverservedStr, charArray[0]);
            //Console.WriteLine("ReverservedStr: " + reverservedStr);

            return reverservedStr;
        }

        //static void Main() 
        //{  
        //    // keep this function call here
        //    Console.WriteLine(FirstReverse(Console.ReadLine()));
        //} 
    }
}
