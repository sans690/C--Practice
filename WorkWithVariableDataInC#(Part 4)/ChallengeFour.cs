using System;

class ChallengeFour
{
    static void Main(string[] args)
    {
        string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
        string[] ids = orderStream.Split(',');
        for (int i = 0; i < ids.Length; i++)
        {
            ids.Sort();
            char[] charArray = ids[i].ToCharArray();
            if (ids[i].Length == 4)
            {
                Console.WriteLine($"{ids[i]}");
            }
            else
            {
                Console.WriteLine($"{ids[i]} - Error");
            }
        }
    }
}