public class ChecklistGoal : Goal
{

        private int _amountCompleted;
        private int _target;
        private int _bonus;

        public ChecklistGoal(string name, string description, int points, int target, int bonus, int completed = 0)
            : base(name, description, points)
        {
            _target = target;
            _bonus = bonus;
            _amountCompleted = completed;
        }

        public override void RecordEvent()
        {
            _amountCompleted++;
            if (_amountCompleted >= _target)
            {
                _amountCompleted = _target;
            _bonus += GetPoints();
            }
        }

        public override bool IsComplete()
        {
            return _amountCompleted >= _target;
        }

        public override string GetDetailsString()
        {
            return $"[ ] {GetName} ({GetDescription}) -- Currently completed: {_amountCompleted}/{_target}";
        }

        public override string GetStringRepresentation()
        {
            return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_target}|{_bonus}|{_amountCompleted}";
        }
    }

