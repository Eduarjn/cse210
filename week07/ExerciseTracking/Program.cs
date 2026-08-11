using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Criação de uma lista para armazenar as atividades (Polimorfismo em ação)
        List<Activity> activities = new List<Activity>();

        // Criando as instâncias e adicionando à lista
        Running runningActivity = new Running("03 Nov 2022", 30, 3.0);
        Cycling cyclingActivity = new Cycling("04 Nov 2022", 45, 12.0);
        Swimming swimmingActivity = new Swimming("05 Nov 2022", 20, 10);

        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        // Iterando pela lista e exibindo os resumos
        Console.WriteLine("Exercise Tracking Summary:");
        Console.WriteLine("--------------------------");
        
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
