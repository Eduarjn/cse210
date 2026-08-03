using System;

namespace MindfulnessApp
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity()
            : base("Breathing Activity", "This activity will help you relax by guiding you through slow breathing.")
        {
        }

        public override void Run()
        {
            DisplayStartingMessage();
            DateTime endTime = DateTime.Now.AddSeconds(Duration);

            while (DateTime.Now < endTime)
            {
                Console.WriteLine("Breathe in...");
                int remainingTime = (int)Math.Max(0, (endTime - DateTime.Now).TotalSeconds);
                int focusTime = Math.Min(4, remainingTime);
                if (focusTime <= 0)
                {
                    break;
                }

                ShowCountdown(focusTime);

                if (DateTime.Now >= endTime)
                {
                    break;
                }

                Console.WriteLine("Breathe out...");
                remainingTime = (int)Math.Max(0, (endTime - DateTime.Now).TotalSeconds);
                focusTime = Math.Min(4, remainingTime);
                if (focusTime <= 0)
                {
                    break;
                }

                ShowCountdown(focusTime);
            }

            DisplayEndingMessage();
            Console.WriteLine("Press Enter to return to the menu...");
            Console.ReadLine();
        }
    }
}
