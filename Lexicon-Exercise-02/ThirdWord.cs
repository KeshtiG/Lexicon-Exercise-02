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
            // Create a boolean flag to indicate if the loop is done or not
            bool done = false;

            /* A "do while" loop to ensure the user gets to try again if they don't enter
             * a correct number of words */
            do
            {
                string userInput = GetUserInput();

                /* Split the input string into words on space and remove empty entries
                 * (extra spaces) with StringSplitOptions and RemoveEmptyEntries */
                var words = userInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                // Check if the input contains at least 3 words
                if (words.Length >= 3)
                {
                    // Display the third word (number 2 in the array)
                    Console.WriteLine($"The third word is: {words[2]}.");

                    // Set the "done" flag to "true" to exit the loop
                    done = true;
                }
                else
                {
                    // If the input doesn't contain at least 3 words, ask the user to try again
                    Console.WriteLine("You need to enter 3 words or more, try again.");
                }
            }
            // Repeat the loop until the "done" flag is set to true
            while (!done);
        }
    }
}
