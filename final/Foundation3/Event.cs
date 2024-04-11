using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanning
{
    public class Event
    {
        private string title;
        private string description;
        private DateTime date;
        private TimeSpan time;
        private Address address;

        public Event(string title, string description, DateTime date, TimeSpan time, Address address)
        {
            this.title = title;
            this.description = description;
            this.date = date;
            this.time = time;
            this.address = address;
        }

        public string GetTitle()
        {
            return title;
        }

        public string GetDescription()
        {
            return description;
        }

        public DateTime GetDate()
        {
            return date;
        }

        public TimeSpan GetTime()
        {
            return time;
        }

        public Address GetAddress()
        {
            return address;
        }

        public virtual string GenerateStandardMessage()
        {
            return $"Event Title: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time}\nAddress: {address}";
        }

        public virtual string GenerateFullMessage()
        {
            return GenerateStandardMessage();
        }

        public virtual string GenerateShortDescription()
        {
            return $"Event Type: {GetType().Name}\nTitle: {title}\nDate: {date.ToShortDateString()}";
        }
    }
}