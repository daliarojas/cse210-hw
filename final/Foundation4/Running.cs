using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracking
{
    public class Running : Activity
    {
        private double distance;

        public Running(DateTime date, int durationMinutes, double distance)
            : base(date, durationMinutes)
        {
            this.distance = distance;
        }

        public override double GetDistance()
        {
            return distance;
        }

        public override double GetSpeed()
        {
            return distance / (base.DurationMinutes / 60.0);
        }

        public override double GetPace()
        {
            return base.DurationMinutes / distance;
        }

        public override string GetSummary()
        {
            return $"{base.GetSummary()} - Distance: {distance} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.00} min per mile";
        }
    }
}