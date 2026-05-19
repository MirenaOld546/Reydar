using System;
using System.Collections.Generic;
using System.Text;

namespace Reydar
{
    abstract class Enity
    {
        public string name { get; protected set; }
        public int ACb { get; protected set; }
        public int HP { get; protected set; }
        public int mHP { get; protected set; }
        public int EP { get; protected set; }
        public int mEP { get; protected set; }
        public int MP { get; protected set; }
        public int mMP { get; protected set; }
        public int HIT { get; protected set; }
        public int DMG { get; protected set; }
        public int DEF { get; protected set; }
        public Stats stats { get; protected set; }

        public Enity(string name, int ACb, int HP, int mHP, int EP, int mEP, int MP, int mMP, Stats stats, int HIT, int DMG, int DEF)
        {
            this.name = name;
            this.ACb = ACb;
            this.HP = HP;
            this.mHP = mHP;
            this.EP = EP;
            this.mEP = mEP;
            this.MP = MP;
            this.mMP = mMP;
            this.stats = stats;
            this.HIT = HIT;
            this.DMG = DMG;
            this.DEF = DEF;

        }
        //Наносим урон противнику
        /*
        public void Damage (Enity enity)
        {
            enity.HP = enity.HP - ((this.stats.STG + this.DMG) - this.DEF);
        }
        */
        public void Attack(Enity target)
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
        }

    }
}
