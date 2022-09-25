// See https://aka.ms/new-console-template for more information


//var time = new JupiterTime();
//time.Hours = 8;
//time.Minutes = 40;

using System.Net.Cache;

//var time = new JupiterTime(7,40);
var time = new JupiterTime(14,88);      //5:28


PrintTime(time);


static void PrintTime(JupiterTime j)
{
    Console.WriteLine($"{j.Hours}:{j.Minutes}");
}

class JupiterTime
{
    private int _minutes;
    private int _hours;
    public int Minutes
    {
        get
        {
            return _minutes;
        }
        set
        {
            if (value >= 60)
            {
                _minutes = value - 60;
                _hours = _hours + 1;
            }
            else if (value < 0)
                _minutes = 0;
            else
                _minutes = value;
        }
    }
    public int Hours
    {
        get
        {
            return _hours;
        }
        set
        {
            if (value >= 10)
                _hours = value - 10;
            else if (value < 0)
                _hours = 0;
            else
                _hours = value;
        }
    }

    

    // add Constructor:
    public JupiterTime(int hours, int minutes)
    {
        Hours = hours;
        Minutes = minutes;
    }
}
