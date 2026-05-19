using System;
using System.Collections.Generic;
using System.Text;

namespace Reydar
{
    class Enemy : Enity
    {
        public int gEXP, gGLD, cLVL, HIT, DMG, DEF;

        public static Enemy enemy1 = new Enemy("Goblin", 0, 6, 6, 0, 0, 0, 0, new Stats(0, 1, 0, 0), 5, 2, 0, 2, 1, 0);
        public Enemy(string name, int ACb, int HP, int mHP, int EP, int mEP, int MP, int mMP, Stats stats, int gEXP, int gGLD, int cLVL, int HIT, int DMG, int DEF) : base(name, ACb, HP, mHP, EP, mEP, MP, mMP, stats)
        {
            this.gEXP = gEXP;
            this.gGLD = gGLD;
            this.cLVL = cLVL;
            this.HIT = HIT;
            this.DMG = DMG;
            this.DEF = DEF;
        }

        public void Attack(Player target)
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
                Console.WriteLine(this.name + " промахнулся.");
            }
        }
    }
}
  
