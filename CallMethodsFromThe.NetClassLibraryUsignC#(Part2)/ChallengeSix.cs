using System;

class ChallengeSix
{
    static void Main(string[] args)
    {
        int currentAssignments = 5;
        int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
        int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
        int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
        int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

        string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

        int[]studentScore = new int[10];

        foreach (string name in studentNames)
        {
            if (name == "Sophia")
            {
                studentScore = sophiaScores;
            }
            else if (name == "Andrew")
            {
                studentScore = andrewScores;
            }
            else if (name == "Emma")
            {
                studentScore = emmaScores;
            }
            else if (name == "Logan")
            {
                studentScore = loganScores;
            }

            int sumScore = 0;
            foreach (int score in studentScore)
            {
               sumScore += score; 
            }
            // continue...see challenge five for full code
            decimal studentAverage = (decimal)sumScore / currentAssignments;
            Console.WriteLine(studentAverage);
        }

    }
}