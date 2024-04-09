using System;
using System.IO;

namespace EternalQuest
{
    public class SimpleGoal : EternalQuest.Goal
    {
        private bool _isComplete;

        public SimpleGoal(string name, string description, int points)
            : base(name, description, points)
        {
        }

        public SimpleGoal() : base(){}

        public SimpleGoal(StreamReader read) : base(read){}

        public override void RecordEvent()
        {
            _isComplete = true;
            Console.WriteLine($"Event recorded for simple goal: {_shortName}");
        }

        public override string GetStringRepresentation()
        {
            return $"{base.GetStringRepresentation()} - Completed: {_isComplete}";
        }

        protected override string GetFriendlyCompleteActionDescription()
        {
            return "completion";
        }

        protected override string GetFriendlyGoalTypeName()
        {
            return "one-time goal";
        }

        public override void Complete()
        {
            if (!_isCompleted)
            {
                _isCompleted = true;
                _pointsEarned += _points;
            }
        }
    }
}