/* https://coderbyte.com/editor/Time%20Convert:Csharp
 * 
 * Using the C# language, have the function TimeConvert(num) take the num 
 * parameter being passed and return the number of hours and minutes the 
 * parameter converts to (ie. if num = 63 then the output should be 1:3). 
 * Separate the number of hours and minutes with a colon. 
 */

namespace DailyChallenges
{
    public class TimeConvert1
    {
        public static string TimeConvert(int num)
        {
            var minutes = num % 60;
            var wholeHours = (num - minutes) / 60;
            return wholeHours + ":" + minutes;
        }

        //static void Main()
        //{     
        //    Should do tryParse to get int...
        //    Console.WriteLine(TimeConvert(Console.ReadLine()))
        //}
    }
}
