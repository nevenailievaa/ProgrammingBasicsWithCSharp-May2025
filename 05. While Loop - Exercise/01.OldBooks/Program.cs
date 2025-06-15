namespace Exercise_Live
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();
            int counterBooks = 0;

            while (true)
            {
                string currentBook = Console.ReadLine();

                if (favouriteBook == currentBook)
                {
                    Console.WriteLine($"You checked {counterBooks} books and found it.");
                    break;
                }
                else if (currentBook == "No More Books")
                {
                    Console.WriteLine($"The book you search is not here!");
                    Console.WriteLine($"You checked {counterBooks} books.");
                    break;
                }

                counterBooks++;
            }
        }
    }
}
