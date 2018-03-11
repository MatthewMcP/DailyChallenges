/* https://projecteuler.net/problem=5
 * 
 * 2520 is the smallest number that can be divided by each of the numbers from 
 * 1 to 10 without any remainder.
 * 
 * What is the smallest positive number that is evenly divisible by all of the
 * numbers from 1 to 20?
 */

using System;
namespace DailyChallenges.ProjectEuler
{
    public class SmallestMultiple_1
    {

        static void Main()
        {
            Console.WriteLine("Starting...");
            for (int i = 1; i < int.MaxValue; i++)
            {
                var isEvenlyDivisible = false;
                for (int j = 1; j < 21; j++)
                {
                    if (i % j != 0)
                    {
                        break;
                    }
                    if (j == 20)
                    {
                        isEvenlyDivisible = true;
                    }
                }

                if (isEvenlyDivisible)
                {
                    Console.WriteLine("Smallest Number is: " + i);
                    break;
                }
                continue;
            }

            Console.WriteLine("End");
            Console.ReadLine();

        }
    }
}
