using System;
using System.Collections.Generic;
using System.Threading;

namespace Mindfulness
{
    class RelaxingActivity : Activity
    {
        int _count;
        private List<string> _prompts;


        public RelaxingActivity()
        {
            _prompts = new List<string>();

            _prompts.Add("Begin by finding a quiet and comfortable space where you can fully immerse yourself in relaxation.");
            _prompts.Add("Close your eyes and focus on your breath, allowing each inhale and exhale to naturally soothe your mind and body.");
            _prompts.Add("Visualize a peaceful scene, such as a tranquil forest or a serene beach, and imagine yourself becoming one with the calming environment.");
            _prompts.Add("Slowly release any tension you may be holding in your muscles, starting from your toes and working your way up to your head.");
            _prompts.Add("Stay in this state of deep relaxation for as long as you need, allowing yourself to experience profound tranquility and rejuvenation.");
        }

        public override void Run()
        {
            Console.WriteLine("Relaxing Activity");
            Console.WriteLine("This exercise fosters gratitude and mindfulness, allowing you to immerse yourself in the abundance of blessings surrounding you. Take a moment to unwind and delve into this serene practice, embracing the beauty of gratitude and self-awareness.");

            Console.WriteLine("Enter duration of activity in seconds:");
            int duration = int.Parse(Console.ReadLine());

            Console.WriteLine("Prepare to begin...");
            Thread.Sleep(3000);
            base.ShowSpinner(duration);

            GetRandomText();

            ShowCountdown(duration);

            Thread.Sleep(duration * 1000);

            Console.WriteLine("Time's up!");


            Console.WriteLine("Well done! You have completed the Relaxing Activity.");
            Thread.Sleep(3000);
        }

        public void GetRandomText()
        {
            Random rand = new Random();
            string randomPrompt = _prompts[rand.Next(0, _prompts.Count)];
            Console.WriteLine(randomPrompt);
        }


    }
}