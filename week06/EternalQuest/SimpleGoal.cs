public class SimpleGoal : Goal{
    bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points){
       _isComplete=false;
    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }

    public override bool IsComplete()
    {
        return _isComplete;
        throw new NotImplementedException();
    }

    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }
}