using System;
using System.Collections.Generic;
using System.Linq;

namespace MindfulnessApp
{
    public class ReflectingActivity : Activity
    {
        private readonly List<string> _prompts;
        private readonly List<string> _questions;

        public ReflectingActivity()
            : base("Reflecting Activity", "This activity will help you reflect on positive experiences in your life.")
        {
            _prompts = new List<string>
            {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you overcame a challenge."
            };

            _questions = new List<string>
            {
                "Why was this experience meaningful to you?",
                "What did you learn about yourself?",
                "How did this experience affect others?",
                "What would you do differently next time?"
            };
        }

        public override void Run()
        {
            DisplayStartingMessage();
            DateTime endTime = DateTime.Now.AddSeconds(Duration);
            Random random = new Random();
            List<string> remainingPrompts = new List<string>(_prompts);
            List<string> remainingQuestions = new List<string>(_questions);

            while (DateTime.Now < endTime)
            {
                if (remainingPrompts.Count == 0)
                {
                    remainingPrompts = new List<string>(_prompts);
                }

                int promptIndex = random.Next(remainingPrompts.Count);
                string prompt = remainingPrompts[promptIndex];
                remainingPrompts.RemoveAt(promptIndex);
                Console.WriteLine(prompt);

                if (remainingQuestions.Count == 0)
                {
                    remainingQuestions = new List<string>(_questions);
                }

                int questionIndex = random.Next(remainingQuestions.Count);
                string question = remainingQuestions[questionIndex];
                remainingQuestions.RemoveAt(questionIndex);
                Console.WriteLine(question);
                ShowSpinner(2);
            }

            DisplayEndingMessage();
            Console.WriteLine("Press Enter to return to the menu...");
            Console.ReadLine();
        }
    }
}
