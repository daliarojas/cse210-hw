using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create addresses
            Address lectureAddress = new Address("123 Main St", "Anytown", "CA", "USA");
            Address receptionAddress = new Address("456 Elm St", "Othertown", "NY", "USA");
            Address outdoorAddress = new Address("789 Oak St", "Sometown", "TX", "USA");

            // Create events
            Lecture lectureEvent = new Lecture("Introduction to Programming", "Learn basics of programming", DateTime.Now.AddDays(7), new TimeSpan(10, 0, 0), lectureAddress, "John Doe", 50);
            Reception receptionEvent = new Reception("Networking Mixer", "Network with professionals", DateTime.Now.AddDays(14), new TimeSpan(18, 30, 0), receptionAddress, "rsvp@example.com");
            OutdoorGathering outdoorEvent = new OutdoorGathering("Picnic in the Park", "Enjoy outdoor activities", DateTime.Now.AddDays(21), new TimeSpan(12, 0, 0), outdoorAddress, "Sunny with a chance of showers");

            // Generate and display messages for each event
            Console.WriteLine("Standard Messages:");
            Console.WriteLine(lectureEvent.GenerateStandardMessage());
            Console.WriteLine(receptionEvent.GenerateStandardMessage());
            Console.WriteLine(outdoorEvent.GenerateStandardMessage());

            Console.WriteLine("\nFull Messages:");
            Console.WriteLine(lectureEvent.GenerateFullMessage());
            Console.WriteLine(receptionEvent.GenerateFullMessage());
            Console.WriteLine(outdoorEvent.GenerateFullMessage());

            Console.WriteLine("\nShort Descriptions:");
            Console.WriteLine(lectureEvent.GenerateShortDescription());
            Console.WriteLine(receptionEvent.GenerateShortDescription());
            Console.WriteLine(outdoorEvent.GenerateShortDescription());

            Console.ReadLine();
        }
    }
}