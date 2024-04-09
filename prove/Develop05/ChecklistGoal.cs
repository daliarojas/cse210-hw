using System;
using System.IO;

namespace EternalQuest
{
    public class ChecklistGoal : EternalQuest.Goal
    {
        private int _amountCompleted;
        private int _target;
        private int _bonus;
        private int _numberOfTimesToComplete = 0;
        private int _numberOfTimesCheckedOff = 0;
        private int _completionBonus = 0;

        public ChecklistGoal(string name, string description, int points, int target, int bonus)
            : base(name, description, points)
        {
            _target = target;
            _bonus = bonus;
        }

        public ChecklistGoal() : base()
        {
            Console.WriteLine("Enter how many times must the checklist goal be completed for a onus? ");
            _numberOfTimesToComplete = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"What is the bonus point reward once it is completed {_numberOfTimesToComplete} times? ");
            _completionBonus = Convert.ToInt32(Console.ReadLine());
        }
        public ChecklistGoal(StreamReader reader) { }

        public override void RecordEvent()
        {
            _amountCompleted++;
            Console.WriteLine($"Event recorded for checklist goal: {_shortName}");
            if (_amountCompleted == _target)
            {
                Console.WriteLine($"Congratulations! You completed the {_shortName} goal and earned a bonus of {_bonus} points.");
            }
        }

        public override string GetDetailsString()
        {
            return $"{base.GetDetailsString()} - Target: {_target}";
        }

        public override string GetStringRepresentation()
        {
            return $"{base.GetStringRepresentation()} - Points: {_points}";
        }

        protected override string GetFriendlyCompleteActionDescription()
        {
            return "each time you accomplish this goal";
        }

        protected override string GetFriendlyGoalTypeName()
        {
            return "checklist goal";
        }

        public override void Complete()
        {
            if (!_isCompleted)
            {
                _numberOfTimesCheckedOff++;
                _pointsEarned += _points;

                if (_numberOfTimesCheckedOff == _numberOfTimesToComplete)
                {
                    _isCompleted = true;
                    _pointsEarned += _completionBonus;
                }
            }
        }
    }
}