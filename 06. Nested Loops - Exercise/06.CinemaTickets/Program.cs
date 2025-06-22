//Input
string movieName = string.Empty;

//Calculations
int studentTickets = 0;
int standardTickets = 0;
int kidTickets = 0;
int allTickets = 0;

while ((movieName = Console.ReadLine()) != "Finish")
{
    int seatsCount = int.Parse(Console.ReadLine());
    string ticketType = string.Empty;
    int soldTickets = 0;

    while ((ticketType = Console.ReadLine()) != "End")
    {
        soldTickets++;

        switch (ticketType)
        {
            case "student":
                studentTickets++;
                break;
            case "standard":
                standardTickets++;
                break;
            case "kid":
                kidTickets++;
                break;
        }

        if (seatsCount == soldTickets)
        {
            break;
        }
    }

    allTickets += soldTickets;
    double percentFilled = (double)soldTickets / seatsCount * 100;
    Console.WriteLine($"{movieName} - {percentFilled:f2}% full.");
}

//Output
Console.WriteLine($"Total tickets: {allTickets}");
Console.WriteLine($"{(double)studentTickets / allTickets * 100:f2}% student tickets.");
Console.WriteLine($"{(double)standardTickets / allTickets * 100:f2}% standard tickets.");
Console.WriteLine($"{(double)kidTickets / allTickets * 100:f2}% kids tickets.");