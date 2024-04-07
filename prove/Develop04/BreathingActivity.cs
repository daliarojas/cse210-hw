using System;
using System.Threading;

namespace Mindfulness
{
    class BreathingActivity : Activity
    {
        public BreathingActivity()
        {
         //   _duration = 0;
        }
       public override void Run()
        {
            Console.WriteLine("Breathing Activity");
            Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

            Console.WriteLine("Enter duration of activity in seconds:");
            int duration = int.Parse(Console.ReadLine());
            //SetDuration(duration);

            Console.WriteLine("Prepare to begin...");
            base.ShowSpinner(duration);
            Thread.Sleep(3000);


            Console.WriteLine("Start breathing...");

            for (int i = 0; i < duration; i += 2)
            {
                Console.WriteLine("Breathe in...");
                ShowCountdown(duration);

                Console.WriteLine("Breathe out...");
                ShowCountdown(duration);
            }

            Console.WriteLine("Well done! You have completed the Breathing Activity.");
            Thread.Sleep(3000);
        }
    }
}