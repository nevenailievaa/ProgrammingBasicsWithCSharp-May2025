namespace _02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int allowedBadGrades = int.Parse(Console.ReadLine());
            string currentTask = Console.ReadLine();
            double totalGrades = 0;
            int counterGrades = 0;
            int counterBadGrades = 0;
            string lastSolvedTask = string.Empty;

            while (currentTask != "Enough")
            {
                int taskGrade = int.Parse(Console.ReadLine());
                totalGrades += taskGrade;
                counterGrades++;

                if (taskGrade <= 4)
                {
                    counterBadGrades++;
                }

                if (counterBadGrades == allowedBadGrades)
                {
                    Console.WriteLine($"You need a break, {counterBadGrades} poor grades.");
                    break;
                }

                lastSolvedTask = currentTask;
                currentTask = Console.ReadLine();
            }

            if (currentTask == "Enough")
            {
                Console.WriteLine($"Average score: {(double)(totalGrades / counterGrades):f2}");
                Console.WriteLine($"Number of problems: {counterGrades}");
                Console.WriteLine($"Last problem: {lastSolvedTask}");
            }
        }
    }
}
