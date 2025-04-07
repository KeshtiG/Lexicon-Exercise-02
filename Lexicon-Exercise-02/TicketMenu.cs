using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Exercise_02
{
    internal static class TicketMenu
    {
        // Handle ticket menu choices
        internal static void HandleTicketChoices()
        {
            //Console.WriteLine("Choose single or group:");

            bool done = false;

            do
            {
                // Display the ticket menu
                DisplayTicketMenu();

                // Handle the prompt and prompt type
                uint ticketChoice = LexiconUtilities.Utils.AskForUInt("Enter a menu number", "choice");

                // Create a new ticket object
                Ticket ticket = new(0);
                uint age;

                switch (ticketChoice)
                {
                    // Single ticket
                    case 1:
                        // Handle the prompt and prompt type
                        age = LexiconUtilities.Utils.AskForUInt("Enter your age", "age");

                        // Create a new ticket object
                        ticket = new(age);

                        Console.WriteLine($"{ticket.GetTicketType()} price: {ticket.GetTicketPrice()} kr.");
                        break;

                    // Group tickets
                    case 2:
                        // Handle the prompt and prompt type
                        uint numberOfTickets = LexiconUtilities.Utils.AskForUInt("Enter number of tickets", "number");

                        // Calculate the total price for a group of tickets
                        uint ticketSum = ticket.CalcGroupSum(numberOfTickets);

                        Console.WriteLine($"{Environment.NewLine}Total sum ({numberOfTickets} tickets): {ticketSum} kr.");
                        break;

                    // Exit to main menu
                    case 0:
                        done = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        continue;
                }

            } while (!done);
        }

        private static void DisplayTicketMenu()
        {
            Console.WriteLine();
            Console.WriteLine("CINEMA TICKET MENU");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("1. Single ticket");
            Console.WriteLine("2. Group tickets");
            Console.WriteLine();
            Console.WriteLine("0. Back to main menu");
            Console.WriteLine("----------------------------------");
        }
    }
}
