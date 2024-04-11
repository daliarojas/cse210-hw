using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create activities
            Activity running = new Running(new DateTime(2022, 11, 3), 30, 3.0);
            Activity cycling = new Cycling(new DateTime(2022, 11, 4), 45, 20);
            Activity swimming = new Swimming(new DateTime(2022, 11, 5), 60, 40);

            // Put activities in a list
            List<Activity> activities = new List<Activity> { running, cycling, swimming };

            // Display summaries for each activity
            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }

            Console.ReadLine();
        }
    }
}