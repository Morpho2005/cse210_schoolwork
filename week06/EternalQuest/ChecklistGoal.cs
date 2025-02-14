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
        Console.WriteLine($"{_description}");
        Console.Write("have you completed this task? (y or n) ");
        string answer = Console.ReadLine();
        if (answer == "y"){
            _amountCompleted += 1;
        } else if (answer != "n"){
            while (answer != "n" || answer != "y"){
                Console.Write("invalid input");
                answer = Console.ReadLine();
            }
            if (answer == "y"){
                _amountCompleted += 1;
            }
        }
        throw new NotImplementedException();
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target){
            return true;
        } else {
            return false;
        }
        throw new NotImplementedException();
    }

    public override string GetStringRepresentation()
    {
        return $"name: {_shortName},description: {_description},points: {_points},target: {_target},amountCompleted: {_amountCompleted},bonus: {_bonus}";
        throw new NotImplementedException();
    }

    public override string GetDetailsString(){
        string checkbox = $"comepleted {_amountCompleted}/{_target} times";
        return $"{_shortName} {_description} {checkbox}";
    }
}