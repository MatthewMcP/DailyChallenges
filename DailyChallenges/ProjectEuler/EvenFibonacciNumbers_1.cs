﻿/* https://projecteuler.net/problem=2
 * 
 * Each new term in the Fibonacci sequence is generated by adding the previous
 * two terms. By starting with 1 and 2, the first 10 terms will be:
 *  
 * 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
 * 
 * By considering the terms in the Fibonacci sequence whose values do not 
 * exceed four million, find the sum of the even-valued terms.
 */

using System;
namespace DailyChallenges.ProjectEuler
{
    public class EvenFibonacciNumbers_1
    {

        static void Main()
        {
            Console.WriteLine("Starting...");

            var a = 1;
            var b = 2;

            var totalSum = 0;

            while (a < 4000000)
            {
                if (a % 2 == 0)
                {
                    totalSum = totalSum + a;
                }

                int temp = a;
                a = b;
                b = temp + b;
            }

            Console.WriteLine("TotalSum: " + totalSum);

            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}