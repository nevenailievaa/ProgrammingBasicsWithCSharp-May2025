﻿//Input
int tournamentsCount = int.Parse(Console.ReadLine());
int initialPoints = int.Parse(Console.ReadLine());

//Calculations
int points = 0;
int winsCount = 0;

for (int i = 1; i <= tournamentsCount; i++)
{
    string tournamentResult = Console.ReadLine();

	switch (tournamentResult)
	{
		case "W":
			points += 2000;
			winsCount++;
            break;
        case "F":
            points += 1200;
            break;
        case "SF":
            points += 720;
            break;
    }
}

int averagePoints = points / tournamentsCount;
points += initialPoints;
double winPercent = (double)winsCount / tournamentsCount * 100;

//Output
Console.WriteLine($"Final points: {points}");
Console.WriteLine($"Average points: {averagePoints}");
Console.WriteLine($"{winPercent:f2}%");