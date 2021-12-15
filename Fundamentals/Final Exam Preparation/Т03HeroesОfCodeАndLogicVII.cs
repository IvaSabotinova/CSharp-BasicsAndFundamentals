using System;
using System.Collections.Generic;
using System.Linq;

namespace Т03HeroesОfCodeАndLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Dictionary<string, List<int>> allHeroes_HP_MP = new Dictionary<string, List<int>>();


            for (int i = 0; i < number; i++)
            {
                string[] command = Console.ReadLine().Split();

                string currentHero = command[0];
                int currentHP = int.Parse(command[1]);
                int currentMP = int.Parse(command[2]);
                if (!allHeroes_HP_MP.ContainsKey(currentHero))
                {
                    allHeroes_HP_MP.Add(currentHero, new List<int>());
                    allHeroes_HP_MP[currentHero].Add(0);
                    allHeroes_HP_MP[currentHero].Add(0);
                }

                allHeroes_HP_MP[currentHero][0] += currentHP;
                allHeroes_HP_MP[currentHero][1] += currentMP;
                if (allHeroes_HP_MP[currentHero][0] > 100)
                {
                    allHeroes_HP_MP[currentHero][0] = 100;
                }

                if (allHeroes_HP_MP[currentHero][1] > 200)
                {
                    allHeroes_HP_MP[currentHero][1] = 200;
                }

            }

            string commands = String.Empty;

            while ((commands = Console.ReadLine()) != "End")
            {
                string[] subcommands = commands.Split(" - ");

                string currCommand = subcommands[0];
                string currHeroName = subcommands[1];

                if (currCommand == "CastSpell")
                {
                    int neededMP = int.Parse(subcommands[2]);
                    string spellName = subcommands[3];
                    if (allHeroes_HP_MP[currHeroName][1] >= neededMP)
                    {
                        Console.WriteLine($"{currHeroName} has successfully cast {spellName} and now has {allHeroes_HP_MP[currHeroName][1] - neededMP} MP!");
                        allHeroes_HP_MP[currHeroName][1] -= neededMP;
                    }
                    else
                    {
                        Console.WriteLine($"{currHeroName} does not have enough MP to cast {spellName}!");
                    }

                }
                else if (currCommand == "TakeDamage")
                {
                    int damage = int.Parse(subcommands[2]);
                    string attacker = subcommands[3];
                    allHeroes_HP_MP[currHeroName][0] -= damage;
                    if (allHeroes_HP_MP[currHeroName][0] > 0)
                    {
                        Console.WriteLine($"{currHeroName} was hit for {damage} HP by {attacker} and now has {allHeroes_HP_MP[currHeroName][0]} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{currHeroName} has been killed by {attacker}!");
                        allHeroes_HP_MP.Remove(currHeroName);
                    }
                }
                else if (currCommand == "Recharge")
                {

                    int amount = int.Parse(subcommands[2]);
                    int oldMP = allHeroes_HP_MP[currHeroName][1];
                    allHeroes_HP_MP[currHeroName][1] += amount;
                    if (allHeroes_HP_MP[currHeroName][1] > 200)
                    {
                        allHeroes_HP_MP[currHeroName][1] = 200;
                        amount = 200 - oldMP;
                    }

                    Console.WriteLine($"{currHeroName} recharged for {amount} MP!");
                }
                else if (currCommand == "Heal")
                {
                    int oldHP = allHeroes_HP_MP[currHeroName][0];
                    int amountHP = int.Parse(subcommands[2]);
                    allHeroes_HP_MP[currHeroName][0] += amountHP;
                    if (allHeroes_HP_MP[currHeroName][0] > 100)
                    {

                        allHeroes_HP_MP[currHeroName][0] = 100;
                        amountHP = 100 - oldHP;

                    }

                    Console.WriteLine($"{currHeroName} healed for {amountHP} HP!");

                }


            }

            foreach (KeyValuePair<string, List<int>> hero in allHeroes_HP_MP.OrderByDescending(x => x.Value[0]).ThenBy(k => k.Key))
            {
                Console.WriteLine($"{hero.Key}");
                Console.WriteLine($"  HP: {hero.Value[0]}");
                Console.WriteLine($"  MP: {hero.Value[1]}");

            }

        }
    }
}
