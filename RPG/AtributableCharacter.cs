using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal abstract class AtributableCharacter : Entity
    {
        public int EXP;
        public int ATK;
        public int SPD;
        public int MAG;
        public int DEF;

        public AtributableCharacter(string name, int HP, int EXP, int ATK, int SPD, int MAG, int DEF) : base(name, HP)
        {
            this.name = name;
            this.HP = HP;
            this.EXP = EXP;
            this.ATK = ATK;
            this.SPD = SPD;
            this.MAG = MAG;
            this.DEF = DEF;
        }
    }
}
