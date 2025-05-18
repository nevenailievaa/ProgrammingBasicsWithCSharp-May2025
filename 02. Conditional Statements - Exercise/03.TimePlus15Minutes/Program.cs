//Input
int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

//Calculations
if (minutes >= 45)
{
    hours = hours + 1;
    minutes = (minutes + 15) % 60;
}
else
{
    minutes = minutes + 15;
}

if (hours == 24)
{
    hours = 0;
}

//Output
Console.WriteLine($"{hours}:{minutes:d2}");