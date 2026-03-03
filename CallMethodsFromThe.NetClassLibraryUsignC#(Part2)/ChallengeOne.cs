using System;
class CallMethodsPart2ChallengeOne()
{
    public static void Run(string[] args)
    {
        int firstValue = 500;
        int secondValue = 600;
        int largerValue = Math.Max(firstValue, secondValue);

        Console.WriteLine(largerValue);
    }
}
