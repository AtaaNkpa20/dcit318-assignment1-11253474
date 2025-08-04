using System;

namespace TicketPriceCalculator
{
    class TicketPrice
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== TICKET PRICE CALCULATOR =====");

            bool validInput = false;

            // Input validation loop
            do
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine() ?? "";

                if (int.TryParse(input, out int age) && age >= 0)
                {
                    int ticketPrice;

                    if (age <= 12 || age >= 65)
                        ticketPrice = 7;
                    else
                        ticketPrice = 10;

                    Console.WriteLine($"Your ticket price is: GHC{ticketPrice}");
                    validInput = true; // Exit loop after valid input
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid age.");
                }

            } while (!validInput);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
