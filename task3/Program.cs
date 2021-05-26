using System;
using System.Collections;

namespace task3
{
    internal static class Program
    {
        private class Dictionary
        {
            public static IEnumerable Generator()
            {
                yield return new {English = "one", Russian = "один"};
                yield return new {English = "two", Russian = "два"};
                yield return new {English = "three", Russian = "три"};
            }
        }

        private static void Main()
        {
            foreach (dynamic item in Dictionary.Generator())
            {
                Console.WriteLine($"{item.English}: {item.Russian}");
            }
        }
    }
}