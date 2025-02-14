public class EternalGoal : Goal{
    string _answer;

    public EternalGoal(string name, string description, int points) : base(name, description, points){
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"{_description}");
        Console.Write("have you completed this task? (y or n) ");
        _answer = Console.ReadLine();
        while (_answer.ToLower() != "n" || _answer.ToLower() != "y"){
            Console.Write("invalid input");
            _answer = Console.ReadLine();
        }
    }

    public override bool IsComplete()
    {
        if (_answer.ToLower() == "y"){
            _answer = "n";
            return true;
        } else {
            return false;
        }
    }

    public override string GetStringRepresentation()
    {
        return $"name:{_shortName},description:{_description},points:{_points}";
    }
}