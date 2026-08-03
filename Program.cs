/*
This program uses inheritance and encapsulation to organize the mindfulness activities in a clear class hierarchy.
To exceed the core requirements, the reflecting activity was designed to avoid repeating prompts and questions until every option has been used during the current session, making the experience feel more varied and engaging.
*/

using System;

namespace MindfulnessApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Mindfulness Program");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflecting Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Quit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine() ?? string.Empty;

                switch (choice)
                {
                    case "1":
                        BreathingActivity breathingActivity = new BreathingActivity();
                        breathingActivity.Run();
                        break;
                    case "2":
                        ReflectingActivity reflectingActivity = new ReflectingActivity();
                        reflectingActivity.Run();
                        break;
                    case "3":
                        ListingActivity listingActivity = new ListingActivity();
                        listingActivity.Run();
                        break;
                    case "4":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
