public abstract class Goal{
    internal string _shortName;
    internal string _description;
    internal int _points;

    public Goal(string name, string description, int points){
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString(){
        string checkbox = "[ ]";
        if (IsComplete()){
            checkbox = "[✓]";
        }
        return $"{_shortName} {_description} {checkbox}";
    }

    public abstract string GetStringRepresentation();
};