public abstract class Activity{
    protected DateTime _dateTime = DateTime.Now;
    protected string _name;
    protected int _length;

    public Activity(int length){
        _length = length;
    }

    public abstract float GetDistance();

    public abstract float GetSpeed();

    public abstract float GetPace();

    public virtual string GetSummary(){
        return $"{_dateTime.ToShortDateString()} {_name} ({_length} min): Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace {GetPace()} min per km";
    }
}