/* https://coderbyte.com/editor/Scale%20Balancing:Csharp
 * 
 * Using the C# language, have the function ScaleBalancing(strArr) read strArr 
 * which will contain two elements, the first being the two positive integer 
 * weights on a balance scale (left and right sides) and the second element 
 * being a list of available weights as positive integers. Your goal is to 
 * determine if you can balance the scale by using the least amount of weights
 * from the list, but using at most only 2 weights. For example: if strArr is 
 * ["[5, 9]", "[1, 2, 6, 7]"] then this means there is a balance scale with a 
 * weight of 5 on the left side and 9 on the right side. It is in fact possible
 * to balance this scale by adding a 6 to the left side from the list of 
 * weights and adding a 2 to the right side. Both scales will now equal 11 and
 * they are perfectly balanced.
There will only ever be one unique solution and the list of available weights 
will not be empty. It is also possible to add two weights to only one side of 
the scale to balance it. If it is not possible to balance the scale then your 
program should return the string not possible. 
 */

using System;
using System.Linq;
namespace DailyChallenges.CoderByte
{
    public class ScaleBalancing1
    {
        public static string ScaleBalancing(string[] strArr1)
        {
            var strArr = new string[] {"[5,9]", "[1,2,6,7]" };

            string currentWeights = strArr[0].Replace("[", string.Empty);
            currentWeights = currentWeights.Replace("]", string.Empty);
            int[] currentWeightInts = currentWeights.Split(',').Select(int.Parse).ToArray();

            int leftSide = currentWeightInts[0];
            int rightSide = currentWeightInts[1];

            if (leftSide == rightSide)
            {
                Console.WriteLine("Equal");
                return string.Empty;
            }

            string availableWeightsStr = strArr[1].Replace("[", string.Empty);
            availableWeightsStr = availableWeightsStr.Replace("]", string.Empty);

            Console.WriteLine("availableWeightsStr: " + availableWeightsStr);
            int[] availableWeights = availableWeightsStr.Split(',').Select(int.Parse).ToArray();


            //Could maybe combine these two if statements but time limitations
            if (leftSide < rightSide)
            {
                for (int i = 0; i < availableWeights.Length; i++)
                {
                    if ((leftSide + availableWeights[i]) == rightSide)
                    {
                        return availableWeights[i].ToString();
                    }

                    for (int j = 0; j < availableWeights.Length; j++)
                    {
                        if (i == j)
                        {
                            continue;
                        }

                        if ((leftSide + availableWeights[i] + availableWeights[j]) == rightSide)
                        {
                            return availableWeights[i] + ", " + availableWeights[j];
                        }
                    }
                }
            }

            if (rightSide < leftSide)
            {
                for (int i = 0; i < availableWeights.Length; i++)
                {
                    if ((rightSide + availableWeights[i]) == leftSide)
                    {
                        return availableWeights[i].ToString();
                    }

                    for (int j = 0; j < availableWeights.Length; j++)
                    {
                        if (i == j)
                        {
                            continue;
                        }

                        if ((rightSide + availableWeights[i] + availableWeights[j]) == leftSide)
                        {
                            return availableWeights[i] + ", " + availableWeights[j];
                        }
                    }
                }
            }


            for (int i = 0; i < availableWeights.Length; i++)
            {
                for (int j = 0; j < availableWeights.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    if ((leftSide + availableWeights[i]) == (rightSide + availableWeights[j]))
                    {
                        return availableWeights[i] + ", " + availableWeights[j];
                    }
                    if ((leftSide + availableWeights[j]) == (rightSide + availableWeights[i]))
                    {
                        return availableWeights[i] + ", " + availableWeights[j];
                    }
                }
            }

            return "not possible";
        }

        //static void Main()
        //{
        //    // keep this function call here
        //    Console.WriteLine(ScaleBalancing(new string[] { "Console.ReadLine()" }));
        //}

    }
}
