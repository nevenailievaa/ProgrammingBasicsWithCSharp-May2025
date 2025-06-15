namespace _05.Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int moneyToReturn = (int)(double.Parse(Console.ReadLine()) * 100);
            //double moneyToReturn = double.Parse(Console.ReadLine()) * 100;
            //double moneyToReturn = Math.Round(double.Parse(Console.ReadLine()) * 100, 1);

            int counterCoins = 0;

            while (moneyToReturn > 0)
            {
                if (moneyToReturn >= 200)
                {
                    moneyToReturn -= 200;
                    counterCoins++;
                }
                else if (moneyToReturn >= 100)
                {
                    moneyToReturn -= 100;
                    counterCoins++;
                }
                else if (moneyToReturn >= 50)
                {
                    moneyToReturn -= 50;
                    counterCoins++;
                }
                else if (moneyToReturn >= 20)
                {
                    moneyToReturn -= 20;
                    counterCoins++;
                }
                else if (moneyToReturn >= 10)
                {
                    moneyToReturn -= 10;
                    counterCoins++;
                }
                else if (moneyToReturn >= 5)
                {
                    moneyToReturn -= 5;
                    counterCoins++;
                }
                else if (moneyToReturn >= 2)
                {
                    moneyToReturn -= 2;
                    counterCoins++;
                }
                else if (moneyToReturn >= 1)
                {
                    moneyToReturn -= 1;
                    counterCoins++;
                }
                //else
                //{
                //    moneyToReturn = 0;
                //}
            }

            Console.WriteLine(counterCoins);
        }
    }
}
