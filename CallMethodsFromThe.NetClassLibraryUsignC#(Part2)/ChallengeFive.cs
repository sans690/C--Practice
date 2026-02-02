using System;

class ChallengeFive
{
    static void Main(string[] args)
    {
        int currentAssignments = 5;

        int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
        int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
        int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
        int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

        string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

        int[] studentScores = new int[10];
        Console.WriteLine("\nStudent\t\tGrade\n");

        foreach (string name in studentNames)
        {
            if (name == "Sophia")
            {
                studentScores = sophiaScores;
            }
            else if (name == "Andrew")
            {
                studentScores = andrewScores;
            }
            else if (name == "Emma")
            {
                studentScores = emmaScores;
            }
            else if (name == "Logan")
            {
                studentScores = loganScores;
            }
            int sumScores = 0;

            foreach (int score in studentScores)
            {
                sumScores += score;
            }

            decimal studentGrades = 0;
            studentGrades = (decimal)sumScores / currentAssignments;

            string currentStudentLetterGrade = "";
            if (studentGrades >= 97)
            {
                currentStudentLetterGrade = "A+";
                Console.WriteLine(currentStudentLetterGrade);
            }
            else if (studentGrades >= 93)
                currentStudentLetterGrade = "A";

            else if (studentGrades >= 90)
                currentStudentLetterGrade = "A-";

            else if (studentGrades >= 87)
                currentStudentLetterGrade = "B+";

            else if (studentGrades >= 83)
                currentStudentLetterGrade = "B";

            else if (studentGrades >= 80)
                currentStudentLetterGrade = "B-";

            else if (studentGrades >= 77)
                currentStudentLetterGrade = "C+";

            else if (studentGrades >= 73)
                currentStudentLetterGrade = "C";

            else if (studentGrades >= 70)
                currentStudentLetterGrade = "C-";

            else if (studentGrades >= 67)
                currentStudentLetterGrade = "D+";

            else if (studentGrades >= 63)
                currentStudentLetterGrade = "D";

            else if (studentGrades >= 60)
                currentStudentLetterGrade = "D-";
            else
            {
                currentStudentLetterGrade = "F";
            }

            Console.WriteLine($"{name}\t\t{studentGrades}\t\t{currentStudentLetterGrade}");
        }
        Console.WriteLine("Press the Enter key to continue");
        Console.ReadLine();
    }
}