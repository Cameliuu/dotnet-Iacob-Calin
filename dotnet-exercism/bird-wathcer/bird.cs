using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] arr = { 0, 2, 5, 3, 7, 8, 4 };
        return arr;
    }

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length - 1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1]++;
    }

    public bool HasDayWithoutBirds()
    {
        if (Array.BinarySearch(birdsPerDay, 0) > 0) return true;
        else return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        if (numberOfDays <= 0) return 0;
        else return birdsPerDay[numberOfDays - 1] + CountForFirstDays(numberOfDays - 1);
    }

    public int BusyDays()
    {
        int days = 0;
        foreach (var bird in birdsPerDay)
            if (bird >= 5) days++;
        return days;
    }
}
