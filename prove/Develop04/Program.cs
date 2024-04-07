using System;
namespace Mindfulness
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to the Activity Program");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Relaxing Activity");
                Console.WriteLine("5. Exit");

                Console.Write("Choose an activity: ");
                int choice = int.Parse(Console.ReadLine());

                Activity activity;

                switch (choice)
                {
                    case 1:
                        activity = new BreathingActivity();
                        break;
                    case 2:
                        activity = new ReflectingActivity();
                        break;
                    case 3:
                        activity = new ListingActivity();
                        break;
                    case 4:
                        activity = new RelaxingActivity();
                        break;
                    case 5:
                        Console.WriteLine("Goodbye!");
                        return;    
                    default:
                        Console.WriteLine("Invalid choice. Please choose again.");
                        continue;
                }

                activity.Run();
            }
        }
    }
}