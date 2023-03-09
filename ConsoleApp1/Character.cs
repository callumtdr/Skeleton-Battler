using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Character
    {
        public string Name;
        public int HitPoints;
        public int MaxHitPoints;
        public Character (string name, int hp, int mhp)
        {
            this.Name = name;
            this.HitPoints = hp;
            this.MaxHitPoints = mhp;
        }

        //public void TryHit()
        //{
        //    Random random = new Random();
        //    int num = random.Next(100);

        //    if (num > 50)
        //    {
        //        BigSwing();
        //    }
        //}

        //public void BigSwing()
        //{
        //    Random random = new Random();
        //    int num = random.Next(12);

        //    int damage = num +1;

        //    DamageCreature(damage);
        //}

        public void DamageCreature(int damage)
        {
            HitPoints -= damage;
            

            if (HitPoints <= 0)
            {
                Console.WriteLine($"{Name} has been slain");
            }

            Console.WriteLine($"{Name} was hurt by that attack, It has {HitPoints} remaining out of {MaxHitPoints}");
        }

        public bool IsSlain()
        {
            if (HitPoints <= 0)
            {
                return true;
            }
            return false;
        }

    }   
}
