using System;

class ChallengeSeven
{
    static void Main(string[] args)
    {

        Random random = new Random();

        Console.WriteLine("Would you like to play? (Y/N)");
        if (ShouldPlay())
        {
            PlayGame();
        }

        void PlayGame()
        {
            var play = true;

            while (play)
            {
                var target = 0;
                var roll = 0;

                roll = random.Next(0, 6);
                target = random.Next(0, 6);

                Console.WriteLine($"Roll a number greater than {target} to win!");
                Console.WriteLine($"You rolled a {roll}");
                Console.WriteLine(WinOrLose(roll, target));
                Console.WriteLine("\nPlay again? (Y/N)");

                play = ShouldPlay();
            }
        }
    }

    static bool WinOrLose(int roll, int target)
    {
        // should determine if th player has won or lost
        if (roll > target)
        {
            return true;
        }
        return false;
    }

    static bool ShouldPlay()
    {
        // should retrieve user input and determine if the user wants to play again
        string userInput = Console.ReadLine().Trim().ToLower();
        if (userInput == "y")
        {
            return true;
        }
        return false;
    }
}