class Running : Activity
{
    private double _distance; // In kilometers

    public Running(string date, int duration, double distance)
        : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / (GetDuration() / 60.0);
    }

    public override double GetPace()
    {
        return GetDuration() / _distance;
    }

}