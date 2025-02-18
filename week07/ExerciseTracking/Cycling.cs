public class Cycling : Activity{
    float _speed;

    public Cycling(int length, float speed) : base(length){
        _speed = speed;
        _name = "Cycling";
    }

    public override float GetDistance()
    {
        return _speed/60 * _length;
    }

    public override float GetSpeed()
    {
        return _speed;
    }

    public override float GetPace()
    {
        return 60/_speed;
    }
}