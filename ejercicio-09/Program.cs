int[] birds = BirdCount.LastWeek();
BirdCount birdCount = new BirdCount(birds);
Console.WriteLine("Pajaritos de hoy: " + birdCount.Today());

birdCount.IncrementTodaysCount();
Console.WriteLine("Pajaritos de hoy después de incrementar: " + birdCount.Today());

Console.WriteLine("¿Hubo algún día sin pajaritos? " + birdCount.HasDayWithoutBirds());
int firstDaysCount = birdCount.CountForFirstDays(3);
Console.WriteLine("Total de pajaritos en los primeros 3 días: " + firstDaysCount);
Console.WriteLine("Días con actividad: " + birdCount.BusyDays());

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[] { 0, 2, 5, 3, 7, 8, 4 };
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
        foreach (int birds in birdsPerDay)
        {
            if (birds == 0)
            {
                return true;
            }
        }

        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int total = 0;

        for (int i = 0; i < numberOfDays; i++)
        {
            total += birdsPerDay[i];
        }

        return total;
    }

    public int BusyDays()
    {
        int busyDays = 0;

        foreach (int birds in birdsPerDay)
        {
            if (birds >= 5)
            {
                busyDays++;
            }
        }

        return busyDays;
    }
}

