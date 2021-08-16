using System;
using System.Linq;

namespace Birthday_Cake_Candles
{
    class Program
    {
        static int birthdayCakeCandles(int[] inputArray)
        {
            int maxNumber = inputArray.Max();
            int result = 0;

            foreach (var number in inputArray)
            {
                if (number == maxNumber) result++;
            }

            return result;
        }
        static void Main(string[] args)
        {
            string size = Console.ReadLine();
            var candles = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(birthdayCakeCandles(candles));
        }
    }
}
