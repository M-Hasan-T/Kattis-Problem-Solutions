using System;

namespace AddingTrouble
{
    internal class AddingTrouble
    {
        static void Main(string[] args)
        {
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Console.WriteLine(numbers[0] + numbers[1] == numbers[2] ? "correct!" : "wrong!");
        }
    }
