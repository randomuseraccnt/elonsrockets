using System.Diagnostics.CodeAnalysis;

struct Rocket
{
    private DateTime _LaunchedTime;
    private bool _Launched;
    private bool _Landed;


    public Rocket()
    {
        _LaunchedTime = DateTime.MinValue;
        _Launched = false;
        _Landed = false;
    }

    public TimeSpan missionDuration
    {
        get
        {
            return DateTime.Now - _LaunchedTime;
        }
    }

    public RocketStatus Status
    {
        get
        {
            if (!_Launched)
                return RocketStatus.NotLaunched;
            if (_Landed)
                return RocketStatus.Landed;
            if (missionDuration.TotalSeconds < 10)
                return RocketStatus.TakingOff;
            return RocketStatus.Orbit;
        }
    }

    public void Launch()
    {
        _Launched = true;
        _LaunchedTime = DateTime.Now;
    }

    public void Land()
    {
        _Landed = true;
    }

}


