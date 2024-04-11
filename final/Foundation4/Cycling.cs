using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracking
{
    public class Cycling : Activity
    {
        private double speed;

        public Cycling(DateTime date, int durationMinutes, double speed)
            : base(date, durationMinutes)
        {
            this.speed = speed;
        }

        public override double GetSpeed()
        {
            return speed;
        }

        public override double GetPace()
        {
            return 60.0 / speed;
        }

        public override string GetSummary()
        {
            return $"{base.GetSummary()} - Speed: {speed:0.0} kph, Pace: {GetPace():0.00} min per km";
        }
    }
}