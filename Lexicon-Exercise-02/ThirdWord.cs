using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Exercise_02
{
    internal class ThirdWord
    {
        internal static string GetUserInput()
        {
            // Handle the prompt and prompt type
            string inputText = LexiconUtilities.Utils.AskForString("Enter 3 words", "words");
            return inputText;
        }

        internal static void DisplayThirdWord()
        {
            // A "do while" loop to ensure the user gets to try again if they don't enter 3 words
            bool done = false;

            do
            {
                string userInput = GetUserInput();

                // Split the input string into words on space and remove empty entries (extra spaces)
                // with StringSplitOptions and RemoveEmptyEntries
                var words = userInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                // Check if the input contains at least 3 words
                if (words.Length >= 3)
                {
                    // Display the third word and set done to true to exit the loop
                    Console.WriteLine($"The third word is: {words[2]}.");
                    done = true;
                }
                else
                {
                    Console.WriteLine("You need to enter 3 words or more.");
                }
            }
            while (!done);
        }
    }
}
