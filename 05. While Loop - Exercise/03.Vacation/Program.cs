namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededTripMoney = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            int daysPassed = 0;
            int daysConsecutiveSpend = 0;

            while (neededTripMoney > availableMoney)
            {
                string action = Console.ReadLine();
                double dailyMoney = double.Parse(Console.ReadLine());
                daysPassed++;

                switch (action)
                {
                    case "save":
                        availableMoney += dailyMoney;
                        daysConsecutiveSpend = 0;
                        break;
                    case "spend":
                        availableMoney -= dailyMoney;
                        daysConsecutiveSpend++;

                        if (availableMoney < 0)
                            availableMoney = 0;
                        break;
                }

                if (daysConsecutiveSpend == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{daysPassed}");
                    return;
                }
            }

            Console.WriteLine($"You saved the money for {daysPassed} days.");
        }
    }
}
