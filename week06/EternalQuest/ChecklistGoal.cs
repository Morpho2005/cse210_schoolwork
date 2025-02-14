public class ChecklistGoal : Goal{

    int _amountCompleted;
    int _target;
    int _bonus;
    
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points){
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }

    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }

    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }

    public override string GetDetailsString(){
        string checkbox = $"comepleted {_amountCompleted}/{_target} times";
        return $"{_shortName} {_description} {checkbox}";
    }
}