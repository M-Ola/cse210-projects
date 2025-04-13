
public class EternalGoal : Goal
{
    
        public EternalGoal(string name, string description, int points)
            : base(name, description, points) { }

        public override void RecordEvent()
        {
            //leave empty
        }

        public override bool IsComplete()
        {
            return false;
        }

        public override string GetStringRepresentation()
        {
            return $"EternalGoal|{GetName()}|{GetDescription()}|{GetPoints()}";
        }
    }



