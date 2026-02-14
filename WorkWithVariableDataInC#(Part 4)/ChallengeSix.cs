using System;

class ChallengeSix
{
    static void Main(string[] args)
    {
        const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

        string quantity = "";
        string output = "";

        // Your work here
        int openingPosition = input.IndexOf("<span>") + 6;
        int closePosition = input.IndexOf("</span>");
        int length = closePosition - openingPosition;
        quantity = input.Substring(openingPosition, length);
        Console.WriteLine($"Quantity: {quantity}");

        output = input
        .Replace("<div>", "")
        .Replace("</div>", "")
        .Replace("&trade;", "&reg;");

        Console.WriteLine(output);
    }
}