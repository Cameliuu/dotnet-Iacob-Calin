using System;

class RemoteControlCar
{
    public int meters = 0;
    public int battery = 100;
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return "Driven" + " " + meters + " " + "meters";
    }

    public string BatteryDisplay()
    {
        return (battery > 0) ? "Battery at" + " " + battery + "%" : "Battery empty";
    }

    public void Drive()
    {
        if (battery > 0)
        {
            meters += 20;
            battery--;
        }
    }
}