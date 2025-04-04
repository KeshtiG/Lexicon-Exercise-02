using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Exercise_02
{
    internal class MainMenu
    {
        // Handles the main menu choices
        internal static void HandleMenuChoices()
        {
            bool exitProgram = false;

            do
            {
                DisplayMainMenu();

                // Handle the prompt and prompt type
                uint choice = LexiconUtilities.Utils.AskForUInt("Enter a menu number", "choice");

                switch (choice)
                {
                    case 1:
                        TicketMenu.HandleTicketChoices();
                        break;
                    case 2:
                        RepeatText.PrintRepeatedText();
                        break;
                    case 3:
                        Console.WriteLine("You selected option 3.");
                        break;
                    case 0:
                        Console.WriteLine("Exiting the program.");
                        exitProgram = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            } while (!exitProgram);
        }

        // Displays the main menu options
        internal static void DisplayMainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("MAIN MENU");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("1. Cinema ticket price calculator");
            Console.WriteLine("2. Repeat text 10 times");
            Console.WriteLine("3. Option 3");
            Console.WriteLine();
            Console.WriteLine("0. Exit the program");
            Console.WriteLine("----------------------------------");
        }
    }
}
