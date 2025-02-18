public class Running : Activity{
    float _distance;

    public Running(int length, float distance) : base(length){
        _distance = distance;
        _name = "Running";
    }

    public override float GetDistance(){
        return _distance;
    }

    public override float GetSpeed()
    {
        return _distance/_length * 60;
    }

    public override float GetPace()
    {
        return _length/_distance;
    }
}