/*  https://projecteuler.net/problem=9
 * 
 */

using System;
namespace DailyChallenges.ProjectEuler
{
    public class SpecialPythagoreanTriplet_1
    {

        static void Main()
        {
            Console.WriteLine("Starting...");

            int finalA = 1;
            int finalB = 1;
            int finalC = 1;

            for (int a = 1; a < 998; a++)
            {
                for (int b = 1; b < 998; b++)
                {
                    for (int c = 1; c < 998; c++)
                    {
                        if (a + b + c == 1000)
                        {
                            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                            {
                                finalA = a;
                                finalB = b;
                                finalC = c;
                                Console.WriteLine("finalA " + finalA);
                                Console.WriteLine("finalB " + finalB);
                                Console.WriteLine("End");
                                break;
                            }
                        }
                    }
                }
            }

            Console.WriteLine("finalA " + finalA);
            Console.WriteLine("finalB " + finalB);
            Console.WriteLine("finalC " + finalC);

            var finalProduct = finalA * finalB * finalC;
            Console.WriteLine("finalProduct " + finalProduct);

            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
