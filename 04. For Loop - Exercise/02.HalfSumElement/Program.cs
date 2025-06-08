//Input
int n = int.Parse(Console.ReadLine());

//Calculations
int sum = 0;
int maxNum = int.MinValue;

for (int i = 1; i <= n; i++)
{
    int currentNum = int.Parse(Console.ReadLine());
    sum += currentNum;

    if (maxNum < currentNum)
    {
        maxNum = currentNum;
    }
}

sum -= maxNum;

//Output
if (sum == maxNum)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {maxNum}");
}
else
{
    int difference = Math.Abs(maxNum - sum);
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {difference}");
}