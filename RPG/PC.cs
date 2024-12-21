using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class PC : AtributableCharacter
    {
        string direction = "T";
        Vector2 position = new Vector2(100, 100);
        public enum RectanglesPC
        {
            upperView,
            lowerView,
            leftView,
            rightView,
        }
        public Dictionary<RectanglesPC, Rectangle> rectangles = new Dictionary<RectanglesPC, Rectangle>
        {
            { RectanglesPC.upperView, new Rectangle(0, 0, 48, 48) },
            { RectanglesPC.lowerView, new Rectangle(0, 0, 48, 48) },
            { RectanglesPC.leftView, new Rectangle(0, 0, 48, 48) },
            { RectanglesPC.rightView, new Rectangle(0, 0, 48, 48) },
        };
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
        
        public Rectangle ComprobateRectangle()
        {
            if (direction == "U")
                return rectangles[RectanglesPC.upperView];
            else if (direction == "D")
                return rectangles[RectanglesPC.lowerView];
            else if (direction == "L")
                return rectangles[RectanglesPC.leftView];
            else
                return rectangles[RectanglesPC.rightView];
        }
        public void Draw(SpriteBatch _spriteBatch)
        {
            _spriteBatch.Draw(
                texture,
                position,
                ComprobateRectangle(),
                Color.White,
                0f,
                new Vector2(texture.Width / 2, texture.Height / 2),
                Vector2.One,
                SpriteEffects.None,
                0f
            );
        }
    }
}
