using LexiconUtilities;

namespace Lexicon_Exercise_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the menu for Exercise 2.");
            Console.WriteLine("Select an option from below.");

            // Call the main menu handler
            MainMenu.HandleMenuChoices();
        }
    }
}