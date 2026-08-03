using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    public class ListingActivity : Activity
    {
        private readonly List<string> _prompts;

        public ListingActivity()
            : base("Listing Activity", "This activity will help you reflect on things you are grateful for.")
        {
            _prompts = new List<string>
            {
                "List things you are grateful for.",
                "List people who have helped you recently.",
                "List moments that made you smile today.",
                "List things you accomplished this week."
            };
        }

        public override void Run()
        {
            DisplayStartingMessage();
            DateTime endTime = DateTime.Now.AddSeconds(Duration);
            Random random = new Random();
            string prompt = _prompts[random.Next(_prompts.Count)];
            Console.WriteLine(prompt);
            ShowCountdown(3);

            List<string> items = new List<string>();
            while (DateTime.Now < endTime)
            {
                Console.Write("Enter an item (or type 'done' to finish): ");
                string input = Console.ReadLine() ?? string.Empty;
                if (string.Equals(input.Trim(), "done", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                if (!string.IsNullOrWhiteSpace(input))
                {
                    items.Add(input);
                }
            }

            Console.WriteLine($"You listed {items.Count} item(s).");
            DisplayEndingMessage();
            Console.WriteLine("Press Enter to return to the menu...");
            Console.ReadLine();
        }
    }
}
