public class EternalGoal : Goal{
    
    public EternalGoal(string name, string description, int points) : base(name, description, points){
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"{_description}");
        Console.Write("have you completed this task? (y or n) ");
        string answer = Console.ReadLine();
        if (answer == "y"){

        }
        throw new NotImplementedException();
    }

    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }

    public override string GetStringRepresentation()
    {
        return $"name: {_shortName},description: {_description},points: {_points}";
        throw new NotImplementedException();
    }
}