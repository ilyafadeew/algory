using System;

namespace ALGORY.Extensions
{
    public static class Console
    {
        public static void WriteLineInColor(string text, ConsoleColor color)
        {
            System.Console.ForegroundColor = color;
            System.Console.WriteLine(text);
            System.Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}