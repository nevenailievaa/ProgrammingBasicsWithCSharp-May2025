namespace _04.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int totalSteps = 0;

            while (input != "Going home")
            {
                totalSteps += int.Parse(input);

                if (totalSteps >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{totalSteps - 10000} steps over the goal!");
                    return;
                }

                input = Console.ReadLine();
            }

            totalSteps += int.Parse(Console.ReadLine());

            if (totalSteps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{totalSteps - 10000} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{10000 - totalSteps} more steps to reach goal.");
            }
        }
    }
}
