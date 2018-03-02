/* https://coderbyte.com/editor/Check%20Nums:Csharp
 * 
 * Using the C# language, have the function CheckNums(num1,num2) take both 
 * parameters being passed and return the string true if num2 is greater 
 * than num1, otherwise return the string false. If the parameter values 
 * are equal to each other then return the string -1. 
 */


using System;
namespace DailyChallenges
{
    public class CheckNum1
    {
        public static string CheckNums(int num1, int num2)
        {
            if(num2 > num1)
            {
                return "true";
            }
            if (num1 > num2)
            {
                return "false";
            }

            return "-1";
        }

        //static void Main()
        //{
        //    //Need to do string to int parsing.
        //    Console.WriteLine(CheckNums(Console.ReadLine()));
        //}
    }
}
