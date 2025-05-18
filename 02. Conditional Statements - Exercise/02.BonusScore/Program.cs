//Input
int number = int.Parse(Console.ReadLine());

//Calculations
double bonusPoints = 0;

if (number <= 100)
{
    bonusPoints = 5;
}
else if (number <= 1000)
{
    bonusPoints = number * 0.2;
}
else if (number > 1000)
{
    bonusPoints = number * 0.1;
}

double additionalBonusPoints = 0;

if (number % 2 == 0)
{
    additionalBonusPoints = 1;
}
else if (number % 10 == 5)
{
    additionalBonusPoints = 2;
}

double allPoints = bonusPoints + additionalBonusPoints;
double sumAll = number + bonusPoints + additionalBonusPoints;

//Output
Console.WriteLine(allPoints);
Console.WriteLine(sumAll);