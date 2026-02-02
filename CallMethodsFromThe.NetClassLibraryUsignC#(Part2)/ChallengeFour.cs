using System;

class ChallengeFour
{
    static void Main(string[] args)
    {
        string originalMessage = "The quick brown fox jumps over the lazy dog.";
        // convert the message into a char array
        char[] message = originalMessage.ToCharArray();
        // reverse the characters
        Array.Reverse(message);
        int letterCount = 0;
        // count the o's
        foreach (char i in message) { if (i == 'o') { letterCount++; } }
        // convert it back to a string
        string newMessage = new String(message);
        // print it out
        Console.WriteLine(newMessage);
        Console.WriteLine($"'o' appears {letterCount} times.");
    }
}