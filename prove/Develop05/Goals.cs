using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    public abstract class Goal
    {
        protected string _shortName;
        protected string _description;
        protected int _points = 0;
        protected int _pointsEarned = 0;
        protected bool _isCompleted = false;

        public int Points
        {
            get
            {
                return _points;
            }
            set
            {
                _points = value;
            }
        }

        public Goal(string name, string description, int points)
        {
            _shortName = name;
            _description = description;
            _points = points;
        }

        public Goal(){
            Console.WriteLine($"What is the name of your {GetFriendlyGoalTypeName()}? ");
            _shortName = Console.ReadLine();

            Console.WriteLine($"What is a short description of your {GetFriendlyGoalTypeName()}? ");
            _description = Console.ReadLine();

            Console.WriteLine($"Enter the points awarded for {GetFriendlyCompleteActionDescription()}? ");
            _points = Convert.ToInt32(Console.ReadLine());
        }

        public Goal(StreamReader read)
        {
            _shortName = read.ReadLine();
            _description = read.ReadLine();
            _points = int.Parse(read.ReadLine());
            _isCompleted = bool.Parse(read.ReadLine());
            _pointsEarned = int.Parse(read.ReadLine());
        }

        protected abstract string GetFriendlyGoalTypeName();

        protected abstract string GetFriendlyCompleteActionDescription();

        public abstract void RecordEvent();

        public abstract void Complete();

        public string GetShortName()
        {
            return _shortName;
        }

        public virtual string GetDetailsString()
        {
            return $"{_shortName} - {_description} - {_points} points";
        }

        public virtual string GetStringRepresentation()
        {
            return $"{_shortName} - {_points} points";
        }

        public bool IsComplete()
        {
            return _isCompleted;
        }

        protected string CompletedCheckbox()
        {
            return _isCompleted ? "[X]" : "[ ]";
        }

        public virtual string GetCompleteDisplayString() 
        {
            return $"{CompletedCheckbox()} {_shortName} ({_description})";
        }

        public virtual void WriteToStreamWriter(StreamWriter w)
        {
            w.WriteLine(_shortName);
            w.WriteLine(_description);
            w.WriteLine(_points);
            w.WriteLine(_isCompleted);
            w.WriteLine(_pointsEarned);
        }

        public int GetPointsEarned()
        {
            return _pointsEarned;
        }


    }
}