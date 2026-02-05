using System;

class ChallengeSix
{
    static void Main(string[] args)
    {
        int heroHealth = 10;
        int monsterHealth = 10;
        int heroAttackValue = Random.Shared.Next(1, 11);
        int monsterAttackValue = Random.Shared.Next(1, 11);
        do
        {
            if (monsterHealth > 0)
            {
                monsterHealth = monsterHealth - heroAttackValue;
                Console.WriteLine($"Monster was damaged and lost {heroAttackValue} health and now has {monsterHealth} health.");
            }

            if (heroHealth > 0)
            {
                heroHealth = heroHealth - monsterAttackValue;
                Console.WriteLine($"Hero was damaged and lost {monsterAttackValue} health and now has {heroHealth} health.");
            }
        } while (monsterHealth > 0 && heroHealth > 0);
        Console.WriteLine(heroHealth > monsterHealth ? "Hero wins!" : "Monster wins!");
    }
}