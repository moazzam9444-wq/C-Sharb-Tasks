using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Warrior : GameCharacter
    {
        public Warrior(string name, int health) : base(name, health)
        {

        }



        public override void UseSpecialAbility()
        {
            Console.WriteLine("The Warrior attacks with a sword!");
        }
        public override void TakeDamage(int amount)
        {
            if (amount > 0)
            {
                int actualDamage = amount - 2;

                if (actualDamage < 0)
                {
                    actualDamage = 0;
                }

                base.TakeDamage(actualDamage);
            }
        }
    }
}
