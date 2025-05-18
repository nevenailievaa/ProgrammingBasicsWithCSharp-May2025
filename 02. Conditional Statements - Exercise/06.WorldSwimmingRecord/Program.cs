//Input
double recordInSeconds = double.Parse(Console.ReadLine());
double metersToSwim = double.Parse(Console.ReadLine());
double secondForOneMeterSwim = double.Parse(Console.ReadLine());

//Calculations
double swimSecondWithoutDelay = metersToSwim * secondForOneMeterSwim;
double delayTimes = Math.Floor(metersToSwim / 15);

double swimSeconds = swimSecondWithoutDelay + delayTimes * 12.5;

//Output
if (swimSeconds < recordInSeconds)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {swimSeconds:f2} seconds.");
}
else
{
    double remainingSeconds = swimSeconds - recordInSeconds;
    Console.WriteLine($"No, he failed! He was {remainingSeconds:f2} seconds slower.");
}