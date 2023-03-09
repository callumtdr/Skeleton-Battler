using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Skeleton : Character
    {
        public Skeleton(string name, int hp, int mhp) : base(name, hp, mhp)
        {

        }

        public void BoneyShank(Character p)
        {
            Random random = new Random();
            int hitChance = random.Next(100);
           
            if (hitChance > 50)
            {

                Random randDam = new Random();
                int dam = randDam.Next(5);

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

