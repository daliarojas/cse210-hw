using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace youtube
{
    public abstract class Media
    {
        public string Title { get; }
        public string Author { get; }
        public int Length { get; }

        public Media(string title, string author, int length)
        {
            Title = title;
            Author = author;
            Length = length;
        }

        public abstract void DisplayInformation();
    }
}