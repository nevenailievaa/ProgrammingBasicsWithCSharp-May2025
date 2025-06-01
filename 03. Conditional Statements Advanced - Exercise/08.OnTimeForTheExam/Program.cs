//Input
int examHour = int.Parse(Console.ReadLine());
int examMinutes = int.Parse(Console.ReadLine());
int studentHour = int.Parse(Console.ReadLine());
int studentMinutes = int.Parse(Console.ReadLine());

//Calculations
int examTimeInMinutes = examHour * 60 + examMinutes;
int studentTimeInMinutes = studentHour * 60 + studentMinutes;

if (examTimeInMinutes < studentTimeInMinutes) // Late
{
    Console.WriteLine("Late");
    int minutesLate = studentTimeInMinutes - examTimeInMinutes;

    if (minutesLate < 60) // Late UNDER one hour
    {
        Console.WriteLine($"{minutesLate} minutes after the start");
    }
    else // Late 1 hour and above
    {
        int hoursLate = minutesLate / 60;
        minutesLate = minutesLate % 60;

        Console.WriteLine($"{hoursLate}:{minutesLate:d2} hours after the start");
    }
}
else //Exactly on time OR Early
{
    int minutesBefore = examTimeInMinutes - studentTimeInMinutes;

    if (minutesBefore == 0) // Exactly on time
    {
        Console.WriteLine("On time");
    }
    else if (minutesBefore <= 30) // Early up to 30 minutes
    {
        Console.WriteLine("On time");
        Console.WriteLine($"{minutesBefore} minutes before the start");
    }
    else
    {
        Console.WriteLine("Early");

        int hoursBefore = minutesBefore / 60;
        minutesBefore = minutesBefore % 60;

        //Early 31 to 59 minutes
        if (hoursBefore == 0 && minutesBefore < 60)
        {
            Console.WriteLine($"{minutesBefore} minutes before the start");
        }
        else
        {
            Console.WriteLine($"{hoursBefore}:{minutesBefore:d2} hours before the start");
        }
    }
}