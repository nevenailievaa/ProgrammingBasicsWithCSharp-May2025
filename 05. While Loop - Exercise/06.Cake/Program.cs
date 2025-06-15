namespace _06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLength = int.Parse(Console.ReadLine());
            int cakeLeft = cakeWidth * cakeLength;

            while (cakeLeft > 0)
            {
                string input = Console.ReadLine();

                if (input == "STOP")
                {
                    if (cakeLeft > 0)
                    {
                        Console.WriteLine($"{cakeLeft} pieces are left.");
                        return;
                    }
                }

                cakeLeft -= int.Parse(input);
            }

            Console.WriteLine($"No more cake left! You need {Math.Abs(cakeLeft)} pieces more.");
        }
    }
}
