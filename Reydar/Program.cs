using System;

namespace Reydar
{
    class Program
    {
        static void Main()

        {
            bool clik = true;
            while (clik)
            {
                Console.WriteLine("Hello world");
                clik = Console.ReadKey().Key != ConsoleKey.F;
                Fight(Player.player1, Enemy.enemy1);
            }
        }

        public static void Fight(Player player, Enemy enemy)
        {
            player.Attack(enemy);
            enemy.Attack(player);
        }
    }
}
