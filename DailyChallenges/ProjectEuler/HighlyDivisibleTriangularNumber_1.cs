/* https://projecteuler.net/problem=12
 * 
 */


//Works but is too slow for Euler rules. Needs to be optimised...


using System;
namespace DailyChallenges.ProjectEuler
{
    public class HighlyDivisibleTriangularNumber_1
    {
        static void Main()
        {
            Console.WriteLine("Starting...");

            long finalTriangularNumber = 0;

            for (int i = 0; i < int.MaxValue; i++)
            {
                long triangularNumber = 0;

                for (int j = 1; j <= i; j++)
                {
                    triangularNumber = triangularNumber + j;
                }
                Console.WriteLine("The " + i + "th triangular is " + triangularNumber);

                var numberOfFactors = 0;
                for (int j = 1; j <= triangularNumber; j++)
                {
                    if (triangularNumber % j == 0)
                    {
                        numberOfFactors = numberOfFactors + 1;
                    }
                }

                Console.WriteLine("triangularNumber: " + triangularNumber + "has " + numberOfFactors + " factors");

                if (numberOfFactors > 500)
                {
                    finalTriangularNumber = triangularNumber;
                    break;
                }
            }
            Console.WriteLine("FinalTriangularNumber: " + finalTriangularNumber);
            Console.WriteLine("End");

            Console.WriteLine("End");
            Console.ReadLine();

        }
    }
}
