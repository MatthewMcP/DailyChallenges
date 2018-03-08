/* https://coderbyte.com/editor/Kaprekars%20Constant:Csharp
 * 
 * Using the C# language, have the function KaprekarsConstant(num) take the 
 * num parameter being passed which will be a 4-digit number with at least two 
 * distinct digits. Your program should perform the following routine on the 
 * number: Arrange the digits in descending order and in ascending order 
 * (adding zeroes to fit it to a 4-digit number), and subtract the smaller 
 * number from the bigger number. Then repeat the previous step. Performing 
 * this routine will always cause you to reach a fixed number: 6174. Then 
 * performing the routine on 6174 will always give you 6174 (7641 - 1467 = 
 * 6174). Your program should return the number of times this routine must 
 * be performed until 6174 is reached. For example: if num is 3524 your 
 * program should return 3 because of the following steps: (1) 5432 - 2345 = 
 * 3087, (2) 8730 - 0378 = 8352, (3) 8532 - 2358 = 6174. 
 */

using System;
using System.Linq;
namespace DailyChallenges.CoderByte
{
    public class KaprekarsConstant1
    {
        public static int KaprekarsConstant(int num)
        {

            var iteration = 0;
            return KaprekarsMethod(num, iteration);
        }

        public static int KaprekarsMethod(int num, int iteration)
        {

            iteration++;

            //This is horrible
            var ascendingNumberEnumerable = num.ToString().ToCharArray().OrderBy(x => x);
            var ascendingNumberString = string.Empty;
            foreach (char c in ascendingNumberEnumerable)
            {
                ascendingNumberString = ascendingNumberString + c;
            }
            Console.WriteLine("ascendingNumberString " + ascendingNumberString);
            var ascendingNumber = int.Parse(ascendingNumberString);


            //This is horrible
            var descendingNumberEnumberale = num.ToString().ToCharArray().OrderBy(x => x).Reverse();
            var descendingNumberString = string.Empty;
            foreach (char c in descendingNumberEnumberale)
            {
                descendingNumberString = descendingNumberString + c;
            }
            Console.WriteLine("descendingNumberString " + descendingNumberString);
            var descendingNumber = int.Parse(descendingNumberString);


            //Adding 0s to the end
            while (descendingNumber < 1000)
            {
                descendingNumber = descendingNumber * 10;
            }


            var result = descendingNumber - ascendingNumber;
            Console.WriteLine("result " + result);

            if (result == 6174)
            {
                return iteration;
            }

            return KaprekarsMethod(result, iteration);
        }

        //static void Main()
        //{
        //    Console.WriteLine(KaprekarsConstant(9831));
        //}
    }
}
