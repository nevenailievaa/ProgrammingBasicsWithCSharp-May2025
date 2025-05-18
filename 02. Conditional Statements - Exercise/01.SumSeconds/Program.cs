//Input
int firstPlayerTime = int.Parse(Console.ReadLine());
int secondPlayerTime = int.Parse(Console.ReadLine());
int thirdPlayerTime = int.Parse(Console.ReadLine());

//Calculations
int timeInSeconds = firstPlayerTime + secondPlayerTime + thirdPlayerTime;
int minutes = timeInSeconds / 60; // 124 / 60 = 2 min.
int seconds = timeInSeconds % 60; // 124 % 60 = 4 sec.

//Output
if (seconds < 10)
{
    Console.WriteLine($"{minutes}:0{seconds}");
}
else
{
    Console.WriteLine($"{minutes}:{seconds}");
}