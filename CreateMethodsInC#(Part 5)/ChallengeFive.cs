using System;

class CreateMethodsPart5ChallengeFive
{
    public static void Run(string[] args)
    {

        Console.WriteLine("Generating random numbers:");
        DisplayRandomNumbers();

        void DisplayRandomNumbers()
        {
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{random.Next(1, 100)}");
            }
            Console.WriteLine();
        }
    }
}