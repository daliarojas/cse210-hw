using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanning
{
    public class OutdoorGathering : Event
    {
        private string weatherForecast;

        public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
            : base(title, description, date, time, address)
        {
            this.weatherForecast = weatherForecast;
        }

        public override string GenerateFullMessage()
        {
            return base.GenerateFullMessage() + $"\nWeather Forecast: {weatherForecast}";
        }
    }
}