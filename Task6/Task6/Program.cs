using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("===== ADVENTURE GAME =====");
            Console.WriteLine();

            Warrior warrior = new Warrior("Alex", 80);
            Wizard wizard = new Wizard("Luna", 70);

            List<GameCharacter> characters = new List<GameCharacter>();

            characters.Add(warrior);
            characters.Add(wizard);

            foreach (GameCharacter character in characters)
            {
                Console.WriteLine($"{character.Name} enters the game!");
                character.UseSpecialAbility();
                Console.WriteLine();
            }

            warrior.TakeDamage(10);
            wizard.TakeDamage(10);

            Console.WriteLine("Alex takes 8 damage.");
            Console.WriteLine($"Alex's health: {warrior.GetHealth()}");
            Console.WriteLine();

            Console.WriteLine("Luna takes 10 damage.");
            Console.WriteLine($"Luna's health: {wizard.GetHealth()}");
            Console.WriteLine();

            warrior.Heal();
            warrior.Heal(15);

            Console.WriteLine();

            HealthPotion potion = new HealthPotion();
            potion.PotionName = "Health Potion";

            potion.Collect();

            Console.WriteLine();

            potion.Use(wizard, "15");
            potion.Use(wizard, "abc");


        }
    }
}
