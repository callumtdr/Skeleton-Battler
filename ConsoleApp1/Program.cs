using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Hero", 20, 20);
            Skeleton skele = new Skeleton("Skeleton", 15, 15);


            //do
            //{
            //    player.BigSwing(skele);
            //    skele.BoneyShank(player);

            //} while (player.HitPoints > 0 || skele.HitPoints > 0);
            do
            {
                if (player.IsSlain() == false)
                {
                    player.BigSwing(skele);

                }

                if (player.IsSlain() == false)
                {
                    skele.BoneyShank(player);
                }
        
            } while (player.HitPoints > 0 && skele.HitPoints > 0);

        }
    }
}
