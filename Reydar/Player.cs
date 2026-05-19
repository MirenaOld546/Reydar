using System;
using System.Collections.Generic;
using System.Text;

namespace Reydar
{
    class Player : Enity
    {
        public int EXP { get; protected set; }
        public int LVL { get; protected set; }

        public static Player player1 = new Player("Mary", 3,15,15,0,0,0,0,new Stats(2,2,1,2),0,1,3,5,1);

        public Player (string name, int ACb, int HP, int mHP, int EP, int mEP, int MP, int mMP, Stats stats, int EXP, int LVL, int HIT, int DMG, int DEF) : base(name, ACb, HP, mHP, EP, mEP, MP, mMP, stats, HIT, DMG, DEF)
        {
            this.EXP = EXP;
            this.LVL = LVL;
        }

        /*public void Attack(Enemy target)
        {
            var x = new Random();
            int p = x.Next(20);
            if (p + this.HIT + this.stats.DEX >= 10 + target.ACb)
            {
                target.HP = target.HP - ((this.stats.STG + this.DMG) - target.DEF);
                Console.WriteLine(this.name + " попал и наносит " + ((this.stats.STG + this.DMG) - target.DEF));
            }
            else
            {
                Console.WriteLine(target.name + " промахнулся.");
            }
        }*/
    }
}
