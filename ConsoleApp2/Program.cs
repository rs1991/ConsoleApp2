using System;

namespace ConsoleApp2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String text, reverseText = "";

            Console.Write("Please enter some text: ");
            text = Console.ReadLine();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reverseText = reverseText + text[i];
            }


            Console.Write("Here is your text in reverse order: " + reverseText);
            Console.Read();
        }
    }
}