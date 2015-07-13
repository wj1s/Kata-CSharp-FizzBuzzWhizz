using System;
using System.Linq;

namespace FizzBuzzWhizz
{
    internal class Program
    {
        private static void Main()
        {
            var keys = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            for (var i = 0; i < 100; i++)
            {
                Console.Out.WriteLine(GetWord(i + 1, keys));
            }
        }

        public static string GetWord(int num, int[] keys)
        {
            if (num.ToString().Contains(keys[0].ToString())) return "Fizz";

            var word = GetWord(num, keys[0], "Fizz")
                + GetWord(num, keys[1], "Buzz")
                + GetWord(num, keys[2], "Whizz");

            return word == "" ? num.ToString() : word;
        }

        private static string GetWord(int num, int key, string word)
        {
            return num % key == 0 ? word : "";
        }
    }
}