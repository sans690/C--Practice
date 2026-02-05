using System;

class ChallengeEight
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
        bool validRole = false;

        do
        {
            string? readResult = Console.ReadLine();

            if (readResult == "Administrator" || readResult == "Manager" || readResult == "User")
            {
                validRole = true;
            }

            else
            {
                validRole = false;
            }

            if (validRole)
            {
                validRole = true;
                Console.WriteLine($"Your input value ({readResult}) has been accepted.");
            }
            else
            {
                validRole = false;
                Console.WriteLine($"The role name that you entered, \"{readResult}\" is not valid. Enter your role name (Administrator, Manager, or User) ");
            }

        } while (!validRole);

    }
}