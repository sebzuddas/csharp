class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method


    public int ExpectedMinutesInOven(){
        int TimeInOven = 40;
        return TimeInOven;
    }

    // TODO: define the 'RemainingMinutesInOven()' method

    public int RemainingMinutesInOven(int ActualTime)
    {
        int RemainingTime = ExpectedMinutesInOven() - ActualTime;
        return RemainingTime;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method

    public int PreparationTimeInMinutes(int Layers)
    {
        return Layers * 2;
    }
    


    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int Layers, int OvenTime)
    {
        int sum;
        sum = PreparationTimeInMinutes(Layers) + OvenTime;
        return sum;
    }

}
