using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Player : Character
    {
        public Player(string name, int hp, int mhp) : base(name, hp, mhp)
        {

        }

        public void BigSwing(Character p)
        {
            Random random = new Random();
            int hitChance = random.Next(100);
            Console.WriteLine("Press any key to roll to hit");
            Console.ReadLine();
            Console.WriteLine($"You rolled a {hitChance}");
            if (hitChance > 50)
            {
                Console.WriteLine("Its a hit!");

                Random randDam = new Random();
                int dam = randDam.Next(12);

                int damage = dam + 1;

                Console.WriteLine($"{Name} Does {damage} amount of damage");

                p.DamageCreature(damage);
 
            }
            else 
            {
                Console.WriteLine($"{Name} missed their attack");
            }


        }

        public bool IsSlain(int hp)
        {
            if (hp <= 0)
            {
                return true;
            }
            return false;
        }
    }
}
