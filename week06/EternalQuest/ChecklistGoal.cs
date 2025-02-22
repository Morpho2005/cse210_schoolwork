public class ChecklistGoal : Goal{

    internal int _amountCompleted;
    int _target;
    internal int _bonus;
    
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points){
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"{GetDetailsString()}");
        Console.Write("have you completed this task? (y or n) ");
        string answer = Console.ReadLine();
        while (answer != "n" & answer != "y"){
            Console.Write("invalid input");
            answer = Console.ReadLine();
        }
        if (answer == "y"){
            _amountCompleted += 1;
            if (_amountCompleted > _target){
                _amountCompleted = _target;
            }
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target){
            return true;
        } else {
            return false;
        }
    }

    public override string GetStringRepresentation()
    {
        return $"name:{_shortName},description:{_description},points:{_points},target:{_target},amountCompleted:{_amountCompleted},bonus:{_bonus}";
    }

    public override string GetDetailsString(){
        return $"{_shortName} {_description} comepleted {_amountCompleted}/{_target} times";
    }
}