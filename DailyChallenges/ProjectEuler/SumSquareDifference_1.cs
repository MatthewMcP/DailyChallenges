/* https://projecteuler.net/problem=6
 * 
 * The sum of the squares of the first ten natural numbers is,
 *
 * 12 + 22 + ... + 102 = 385
 * The square of the sum of the first ten natural numbers is,
 * (1 + 2 + ... + 10)2 = 552 = 3025
 * Hence the difference between the sum of the squares of the first ten natural
 * numbers and the square of the sum is 3025 − 385 = 2640.
 * 
 * Find the difference between the sum of the squares of the first one hundred
 * natural numbers and the square of the sum.
 */

using System;
namespace DailyChallenges.ProjectEuler
{
    public class SumSquareDifference_1
    {

        static void Main1()
        {
            Console.WriteLine("Starting...");

            var totalSumOfSquares = 0;

            var totalSummed = 0;
            var totalSquareOfSums = 0;

            for (int i = 0; i < 101; i++)
            {
                var iSquared = Math.Pow(i, 2);
                totalSumOfSquares = totalSumOfSquares + (int)iSquared;

                totalSummed = totalSummed + i;
            }

            totalSquareOfSums = (int)Math.Pow(totalSummed, 2);

            Console.WriteLine("totalSumOfSquares: " + totalSumOfSquares);
            Console.WriteLine("totalSquareOfSums: " + totalSquareOfSums);

            var result = totalSquareOfSums - totalSumOfSquares;
            Console.WriteLine("End " + result);

            Console.WriteLine("End");
            Console.ReadLine();

        }
    }
}
