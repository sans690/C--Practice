using System;
using System.Text;

class RepeatChallengeThree
{
    static void Main(string[] args)
    {
        string pangram = "The quick brown fox jumps over the lazy dog";
        string[] words = pangram.Split(" ");
        for (int i = 0; i < words.Length; i++)
        {
            char[] characters = words[i].ToCharArray();
            Array.Reverse(characters);
            words[i] = new string(characters);
        }

        string result = String.Join(" ", words);
        Console.WriteLine(result);
    }

}

