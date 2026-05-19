using System;
using System.Collections.Generic;
using System.Text;

namespace Reydar
{
    abstract class Enity
    {
        public string name;
        public int ACb, HP, mHP, EP, mEP, MP, mMP;
        public Stats stats;

        public Enity(string name, int ACb, int HP, int mHP, int EP, int mEP, int MP, int mMP, Stats stats)
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

        }
    }
}
