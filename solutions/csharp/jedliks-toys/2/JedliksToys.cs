class RemoteControlCar
{
    private int _distance = 0;
    private float _batteryCharge = 100;


    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return "Driven " + _distance + " meters";
    }

    public string BatteryDisplay()
    {
        if (_batteryCharge <= 0)
        {
            return "Battery empty";
        }
        else
        {
            return "Battery at " + _batteryCharge + "%";
        }

    }

    public void Drive()
    {
        if (_distance <= 1980)
        {
            _distance = _distance + 20;
            _batteryCharge = _batteryCharge - 1;
        }
    }
}
