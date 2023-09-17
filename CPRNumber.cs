using System;
using System.Linq;

namespace CPRNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string strInput = Console.ReadLine().Replace("-", "");
            int[] input = strInput.Select(x => x - '0').ToArray();
            for (int i = 4; i >= 2; i--)
            {
                sum += i * input[4 - i];
            }
            for (int i = 7; i >= 1; i--)
            {
                sum += i * input[10 - i];
            }
            Console.WriteLine(sum % 11 == 0 ? 1 : 0);
        }
    }
}
