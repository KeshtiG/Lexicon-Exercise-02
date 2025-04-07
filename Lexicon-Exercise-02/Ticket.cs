using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Exercise_02
{
    internal class Ticket
    {
        private string TicketType { get; }
        private uint Price { get; }

        // Constructor
        internal Ticket(uint age)
        {
            TicketType = SetTicketType(age);
            Price = SetTicketPrice(TicketType);
        }

        // Set ticket price based on age
        private static string SetTicketType(uint age)
        {
            // Define age limits for youth and pensioner (easy to change)
            int youth = 19;
            int pensioner = 65;

            // Nested if statement to determine ticket type
            if (age < 5 || age > 100)
                return "Free";

            else
            {
                if (age <= youth)
                    return "Youth";

                else if (age >= pensioner)
                    return "Pensioner";

                else
                    return "Standard";
            }
        }

        // Set ticket price based on ticket type
        private static uint SetTicketPrice(string ticketType)
        {
            if (ticketType == "Free")
                return 0;
            else if (ticketType == "Youth")
                return 80;
            else if (ticketType == "Pensioner")
                return 90;
            else
                return 120;
        }

        // Return the ticket price
        internal uint GetTicketPrice()
        {
            return Price;
        }

        // Return the ticket type
        internal string GetTicketType()
        {
            return TicketType;
        }

        // Calculate the total price for a group of tickets
        internal uint CalcGroupSum(uint numberOfTickets)
        {
            uint ticketSum = 0;
            uint age;

            // Create a list to store tickets
            List<Ticket> tickets = new List<Ticket>();

            for (int ticketNumber = 1; ticketNumber <= numberOfTickets; ticketNumber++)
            {
                age = LexiconUtilities.Utils.AskForUInt($"Enter age for ticket {ticketNumber}", "age");

                // Create a new ticket for each age entered
                Ticket ticketInGroup = new(age);

                // Add the ticket to the list
                tickets.Add(ticketInGroup);

                // Get the ticket price for the current ticket
                uint ticketPrice = ticketInGroup.GetTicketPrice();

                // Sum the ticket prices
                ticketSum += ticketPrice;
            }

            return ticketSum;
        }

    }
}
