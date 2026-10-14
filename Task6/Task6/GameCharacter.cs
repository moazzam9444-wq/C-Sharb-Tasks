using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    abstract class GameCharacter
    {
        private string _name;
        private int health;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        protected int Health
        {
            set
            {
                if (value >= 0 && value <= 100)
                {
                    health = value;
                }
            }
            get { return health; }
        }
        public int GetHealth()
        {
            return Health;
        }



        public GameCharacter(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public virtual void TakeDamage(int amount)
        {

            if (amount > 0 && amount <= health)
            {
                Health -= amount;
            }
            else if (amount > 0 && amount > health)
            {

                Health = 0;
            }


        }

        public abstract void UseSpecialAbility();

        public void Heal()
        {
            if (Health + 10 > 100)
            {
                Health = 100;
            }
            else
            {
                Health += 10;
            }

            Console.WriteLine($"Current Health: {Health}");
        }

        public void Heal(int amount)
        {
            if (amount > 0)
            {
                if (Health + amount > 100)
                {
                    Health = 100;
                }
                else
                {
                    Health += amount;
                }
            }

            Console.WriteLine($"Current Health: {Health}");
        }




    }
}