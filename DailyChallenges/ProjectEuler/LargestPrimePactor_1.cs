/* https://projecteuler.net/problem=3
 * 
 * The prime factors of 13195 are 5, 7, 13 and 29.
 * 
 * What is the largest prime factor of the number 600851475143 ?
 */


/*
using System;
using System.Collections.Generic;

namespace DailyChallenges.ProjectEuler
{
    public class LargestPrimePactor_1
    {

        //1) While n is divisible by 2, print 2 and divide n by 2.
        //2) After step 1, n must be odd. Now start a loop from i = 3 to square root of n. 
        //While i divides n, print i and divide n by i, increment i by 2 and continue.
        //3) If n is a prime number and is greater than 2, then n will not become 1 by above two steps. 
        //So print n if it is greater than 2.


        static void Main()
        {
            Console.WriteLine("Starting...");

            var number = 315; //600851475143;
            List<int> primeFactorList = new List<int>();
            primeFactors(315);
            Console.ReadLine();

            while (number % 2 == 0)
            {
                primeFactorList.Add(2);
                number = number / 2;
            }

            for (int i = 3; i < Math.Sqrt(number); i = i + 2)
            {
                if (number % i == 0)
                {
                    primeFactorList.Add(i);
                    number = number / i;
                }
            }

            if (number > 2)
            {
                primeFactorList.Add(number);
            }

            var largestPrimeFactor = 0;

            Console.WriteLine("PrimeFactorList: ");
            foreach (int i in primeFactorList)
            {
                Console.Write(i + ", ");

            }

            Console.WriteLine("largestPrimeFactor: " + largestPrimeFactor);


            Console.WriteLine("End");
            Console.ReadLine();
        }


        static void primeFactors(int n)
        {
            // Print the number of 2s that divide n
            while (n % 2 == 0)
            {
                Console.Write("%d ", 2);
                n = n / 2;
            }

            // n must be odd at this point.  So we can skip 
            // one element (Note i = i +2)
            for (int i = 3; i <= Math.Sqrt(n); i = i + 2)
            {
                // While i divides n, print i and divide n
                while (n % i == 0)
                {
                    Console.Write("%d ", i.ToString());
                    n = n / i;
                }
            }

            // This condition is to handle the case when n 
            // is a prime number greater than 2
            if (n > 2)
                Console.Write("%d ", n);
        }

    }
}*/