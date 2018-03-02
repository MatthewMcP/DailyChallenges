/* https://coderbyte.com/editor/guest:First%20Factorial:Csharp
 * 
 * Using the C# language, have the function FirstFactorial(num) take the num parameter 
 * being passed and return the factorial of it (e.g. if num = 4, return (4 * 3 * 2 * 1)). 
 * For the test cases, the range will be between 1 and 18 and the input will always be an integer.
 * */

namespace DailyChallenges
{
    public class FactorialNumber1
    {
        public static int FirstFactorial(int num)
        {
            var total = 1; //Setting as 1 because anything x1 is the same
            while (num > 1)
            {
                total = total * num;
                num = num - 1;
            }

            return total;
        }

        //static void Main(string[] args)
        //{

        //    var consoleInput = Console.ReadLine();
        //    int inputInt = 0;

        //    if (Int32.TryParse(consoleInput, out inputInt))
        //    {
        //        Console.WriteLine(FirstFactorial(inputInt));
        //    }
        //    else
        //    {
        //        Console.WriteLine("Input Error");
        //    }

        //    Console.WriteLine("Finished");
    }
}




