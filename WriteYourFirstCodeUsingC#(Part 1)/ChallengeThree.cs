using System;

class WritePart1ChallengeThree
{
    public static void Run(string[] args)
    {
    int fahrenheit = 94;
    int step = fahrenheit - 32;
    decimal celsius = step * (5m / 9m);
    Console.WriteLine($"This temperature is {celsius} Celsius.");
    Console.WriteLine("Windows " + 7 + 4);
    }
}