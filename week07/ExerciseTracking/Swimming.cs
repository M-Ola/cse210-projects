class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int duration, int laps)
        : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 0.05; // 1 lap = 50m = 0.05km
    }

    public override double GetSpeed()
    {
        return GetDistance() / (GetDistance() / 60.0);
    }

    public override double GetPace()
    {
        return GetDuration() / GetDistance();
    }


}