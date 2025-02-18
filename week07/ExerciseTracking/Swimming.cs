public class Swimming : Activity{
    int _laps;

    public Swimming(int length, int laps) : base(length){
        _laps = laps;
        _name = "Swimming";
    }

    public override float GetDistance()
    {
        float lapDistance = _laps*50;
        return lapDistance / 1000;
    }

    public override float GetSpeed()
    {
        return GetDistance()/_length*60;
    }

    public override float GetPace()
    {
        return _length/GetDistance();
    }

    public override string GetSummary()
    {
        return $"{_dateTime.ToShortDateString()} {_name} ({_length} min): Laps {_laps}, Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace {GetPace()} min per km";
    }
}