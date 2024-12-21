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
    abstract class Entity
    {
        public Texture2D texture;
        public string name;
        public int HP;

        public Entity(string name, int HP)
        {
            this.name = name;
            this.HP = HP;
        }
    }
}
