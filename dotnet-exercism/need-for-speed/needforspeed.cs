class RemoteControlCar
{
    public int distance = 0;
    public int speed;
    public int batteryDrain;
    public int battery = 100;
    public RemoteControlCar(int Speed, int BatteryDrain)
    {
        speed = Speed;
        batteryDrain = BatteryDrain;
    }
    public bool BatteryDrained()
    {
        if (battery < batteryDrain) return true;
        else return false;
    }

    public int DistanceDriven()
    {
        return distance;
    }

    public void Drive()
    {
        if (!BatteryDrained())
        {
            distance += speed;
            battery -= batteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    int distance;

    public RaceTrack(int Distance)
    {
        distance = Distance;
    }
    public bool CarCanFinish(RemoteControlCar car)
    {
        while (!car.BatteryDrained())
        {
            car.Drive();
        }
        if (car.DistanceDriven() >= distance) return true;
        else return false;
    }
}