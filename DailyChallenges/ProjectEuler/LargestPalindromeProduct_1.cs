/* https://projecteuler.net/problem=4
 * 
 * A palindromic number reads the same both ways. The largest palindrome made 
 * from the product of two 2-digit numbers is 9009 = 91 × 99.
 * 
 * Find the largest palindrome made from the product of two 3-digit numbers.
 */

using System;
namespace DailyChallenges.ProjectEuler
{
    public class LargestPalindromeProduct
    {

        static void Main1()
        {


            Console.WriteLine("Starting...");

            var largestPalindrome = 0;

            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    var attemptedPalidrone = i * j;
                    if (attemptedPalidrone > largestPalindrome && IsPalidrome(attemptedPalidrone))
                    {
                        largestPalindrome = attemptedPalidrone;
                    }
                }
            }

            Console.WriteLine("largestPalindrome: " + largestPalindrome);


            Console.WriteLine("End");
            Console.ReadLine();

        }

        private static bool IsPalidrome(int n)
        {
            char[] nCharArray = n.ToString().ToCharArray();


            if (nCharArray.Length == 1)
            {
                return true;
            }

            for (int i = 0; i < nCharArray.Length / 2; i++)
            {
                if (nCharArray[i] != nCharArray[nCharArray.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
