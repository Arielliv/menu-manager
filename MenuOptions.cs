using System;
using System.Linq;

namespace Ex04.Menus.Test
{
    public static class MenuOptions
    {
        private const string k_CurrenctVersion = "23.2.4.9805";

        public static void ShowDate()
        {
            Console.WriteLine($"The date is: {DateTime.Today.ToString("dd-MM-yyyy")}{Environment.NewLine}");
        }

        public static void ShowTime()
        {
            Console.WriteLine($"The hour is: {DateTime.Now.ToString("HH:mm:ss")}{Environment.NewLine}");
        }

        public static void ShowVersion()
        {
            Console.WriteLine($"Version: {k_CurrenctVersion}{Environment.NewLine}");
        }

        public static void CountSpaces()
        {
            int spacesCounter;
            string sentenceInput;

            Console.WriteLine("Please write a sentence:");
            sentenceInput = Console.ReadLine();
            spacesCounter = sentenceInput.Count(Char.IsWhiteSpace);
            Console.WriteLine($"There are {spacesCounter} spaces in the given sentence.{Environment.NewLine}");
        }
    }
}
