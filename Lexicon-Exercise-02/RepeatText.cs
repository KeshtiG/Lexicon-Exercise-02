using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Exercise_02
{
    internal static class RepeatText
    {
        internal static string GetUserInput()
        {
            // Handle the prompt and prompt type
            string inputText = LexiconUtilities.Utils.AskForString("Enter text to repeat", "text");
            return inputText;
        }

        internal static void PrintRepeatedText()
        {
            string[] strings = new string[10];
            string textToRepeat = GetUserInput();
            for (int i = 0; i < 10; i++)
            {
                // Add formatted text to the array, with each element numbered starting from 1
                strings[i] = $"{i + 1}. {textToRepeat}";
            }

            // Join the array elements into a single string with a comma and space as the separator
            string joinedText = string.Join(", ", strings);
            Console.WriteLine(joinedText);
        }
    }
}
