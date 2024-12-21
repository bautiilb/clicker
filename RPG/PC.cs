using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class PC : AtributableCharacter
    {
        public PC(string name, int HP, int EXP, int ATK, int SPD, int MAG, int DEF) : base(name, HP, EXP, ATK, SPD, MAG, DEF)
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
