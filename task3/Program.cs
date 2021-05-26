using System;

namespace task3
{
    internal static class Program
    {
        private static void Main()
        {
            var dictionary = new
                {englishWords = new[] {"one", "two", "three"}, russianWords = new[] {"один", "два", "три"}};
            for (var i = 0; i < dictionary.englishWords.Length; i++)
            {
                Console.WriteLine($"{dictionary.englishWords[i]}: {dictionary.russianWords[i]}");
            }
        }
    }
}