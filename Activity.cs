using System;
using System.Threading;

namespace MindfulnessApp
{
    public abstract class Activity
    {
        private string _name;
        private string _description;
        private int _duration;

        protected Activity(string name, string description)
        {
            _name = name;
            _description = description;
            _duration = 0;
        }

        protected string Name => _name;
        protected string Description => _description;
        protected int Duration
        {
            get => _duration;
            set => _duration = value;
        }

        protected void DisplayStartingMessage()
        {
            Console.Clear();
            Console.WriteLine($"Starting {Name}...");
            Console.WriteLine(Description);
            Console.Write("How long, in seconds, would you like your session to last? ");

            string input = Console.ReadLine() ?? string.Empty;
            if (int.TryParse(input, out int parsed) && parsed > 0)
            {
                Duration = parsed;
            }
            else
            {
                Console.WriteLine("Invalid input. Using 30 seconds instead.");
                Duration = 30;
            }

            Console.WriteLine("Get ready...");
            ShowSpinner(3);
        }

        protected void DisplayEndingMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Well done!!");
            Console.WriteLine($"You completed the {Name} for {Duration} seconds.");
            ShowSpinner(3);
        }

        protected void ShowSpinner(int seconds)
        {
            DateTime endTime = DateTime.Now.AddSeconds(seconds);
            char[] spinnerChars = { '|', '/', '-', '\\' };
            int index = 0;

            while (DateTime.Now < endTime)
            {
                Console.Write($"\b \b{spinnerChars[index]}");
                Thread.Sleep(250);
                index = (index + 1) % spinnerChars.Length;
            }

            Console.Write("\b \b");
        }

        protected void ShowCountdown(int seconds)
        {
            for (int i = seconds; i >= 1; i--)
            {
                Console.Write($"\b \b{i}");
                Thread.Sleep(1000);
            }

            Console.Write("\b \b");
        }

        public abstract void Run();
    }
}
