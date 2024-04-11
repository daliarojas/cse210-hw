using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracking
{
    public class Activity
    {
        private DateTime date;
        private int durationMinutes;

        public Activity(DateTime date, int durationMinutes)
        {
            this.date = date;
            this.durationMinutes = durationMinutes;
        }

        public int DurationMinutes
        {
            get { return durationMinutes; }
            set { durationMinutes = value; }
        }

        public virtual double GetDistance()
        {
            return 0; // Default implementation, overridden in derived classes
        }

        public virtual double GetSpeed()
        {
            return 0; // Default implementation, overridden in derived classes
        }

        public virtual double GetPace()
        {
            return 0; // Default implementation, overridden in derived classes
        }

        public virtual string GetSummary()
        {
            return $"{date.ToShortDateString()} (Duration: {durationMinutes} min)";
        }
    }
}