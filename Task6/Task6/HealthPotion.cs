using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class HealthPotion : ICollectible
    {
        public string PotionName { get; set; }

        public void Collect()
        {
            Console.WriteLine("Health Potion collected!");
        }

        public void Use(GameCharacter character, string amountText)
        {
            try
            {
                int amount = int.Parse(amountText);

                character.Heal(amount);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid input! Number is too large or too small.");
            }
        }
    }
}
