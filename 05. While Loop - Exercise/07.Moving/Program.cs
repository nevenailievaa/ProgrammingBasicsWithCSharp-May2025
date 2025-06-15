namespace _07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int roomWidth = int.Parse(Console.ReadLine());
            int roomLength = int.Parse(Console.ReadLine());
            int roomHeight = int.Parse(Console.ReadLine());
            int spaceAvailable = roomWidth * roomLength * roomHeight;

            while (spaceAvailable > 0)
            {
                string input = Console.ReadLine();

                if (input == "Done")
                {
                    Console.WriteLine($"{spaceAvailable} Cubic meters left.");
                    return;
                }

                spaceAvailable -= int.Parse(input);
            }

            Console.WriteLine($"No more free space! You need {Math.Abs(spaceAvailable)} Cubic meters more.");
        }
    }
}
