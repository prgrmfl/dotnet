// See https://aka.ms/new-console-template for more information


var time = new JupiterTime();
time.Hours = 8;
time.Minutes = 40;

PrintTime(time);


static void PrintTime(JupiterTime j)
{
    Console.WriteLine($"{j.Hours}:{j.Minutes}");
}

class JupiterTime
{
    public int Hours
    {
        get;
        set;
    }

    public int Minutes
    {
        get;
        set;
    }
}
