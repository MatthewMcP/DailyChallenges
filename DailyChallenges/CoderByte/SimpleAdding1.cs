/*
https://coderbyte.com/editor/Simple%20Adding:Csharp

Using the C# language, have the function SimpleAdding(num) add up all the 
numbers from 1 to num. For example: if the input is 4 then your program should 
return 10 because 1 + 2 + 3 + 4 = 10. For the test cases, the parameter num 
will be any number from 1 to 1000. 
*/

using System;
namespace DailyChallenges.CoderByte
{
    public class SimpleAdding1
    {
        public static int SimpleAdding(string input)
        {

            int intInput;

            if (int.TryParse(input, out intInput))
            {

                int totalAdd = 0;
                for (int i = 0; i <= intInput; i++)
                {
                    totalAdd = totalAdd + i;
                }

                return totalAdd;
            }
            return 0;
        }

        //static void Main()
        //{
        //    Console.WriteLine(SimpleAdding(Console.ReadLine()));
        //}
    }
}
