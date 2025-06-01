//Input
string typeFlowers = Console.ReadLine();
int flowersCount = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());

//Prices
double rosePrice = 5.00;
double dahliaPrice = 3.80;
double tulipPrice = 2.80;
double narcissusPrice = 3.00;
double gladiolusPrice = 2.50;

//Calculations
double bill = 0;

if (typeFlowers == "Roses")
{
    bill = flowersCount * rosePrice;

    if (flowersCount > 80)
    {
        bill = bill * 0.9; // bill *= 0.9;
    }
}
else if (typeFlowers == "Dahlias")
{
    bill = flowersCount * dahliaPrice;

    if (flowersCount > 90)
    {
        bill = bill * 0.85;
    }
}
else if (typeFlowers == "Tulips")
{
    bill = flowersCount * tulipPrice;

    if (flowersCount > 80)
    {
        bill = bill * 0.85;
    }
}
else if (typeFlowers == "Narcissus")
{
    bill = flowersCount * narcissusPrice;

    if (flowersCount < 120)
    {
        bill = bill * 1.15;
    }
}
else if (typeFlowers == "Gladiolus")
{
    bill = flowersCount * gladiolusPrice;

    if (flowersCount < 80)
    {
        bill = bill * 1.20;
    }
}

//Output
if (budget >= bill)
{
    double remainingMoney = budget - bill;
    Console.WriteLine($"Hey, you have a great garden with {flowersCount} {typeFlowers} and {remainingMoney:f2} leva left.");
}
else
{
    double neededMoney = bill - budget;
    Console.WriteLine($"Not enough money, you need {neededMoney:f2} leva more.");
}