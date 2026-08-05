using System;
// CREATIVITY AND EXCEEDING REQUIREMENTS:
// 1. Added a "Leveling System" in the GoalManager. The user levels up for every 1000 points earned, adding a gamification element.
// 2. Created a new goal type called "NegativeGoal" (Bad Habit). This allows the user to track bad habits they want to quit. When an event is recorded for a negative goal, it deducts points from their total score instead of adding them.

class Program
{
  static void Main(string[] args)
  {
    GoalManager manager = new GoalManager();
    manager.Start();
  }
}
