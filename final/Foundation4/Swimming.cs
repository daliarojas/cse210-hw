using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracking
{
    public class Swimming : Activity
    {
        private int laps;

        public Swimming(DateTime date, int durationMinutes, int laps)
            : base(date, durationMinutes)
        {
            this.laps = laps;
        }

        public override double GetDistance()
        {
            return laps * 50 / 1000.0; // Convert meters to kilometers
        }

        public override double GetSpeed()
        {
            return GetDistance() / (base.DurationMinutes / 60.0);
        }

        public override double GetPace()
        {
            return base.DurationMinutes / GetDistance();
        }

        public override string GetSummary()
        {
            return $"{base.GetSummary()} - Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.00} min per km";
        }
    }
}