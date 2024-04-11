using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanning
{
    public class Reception : Event
    {
        private string rsvpEmail;

        public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
            : base(title, description, date, time, address)
        {
            this.rsvpEmail = rsvpEmail;
        }

        public override string GenerateFullMessage()
        {
            return base.GenerateFullMessage() + $"\nRSVP Email: {rsvpEmail}";
        }
    }
}