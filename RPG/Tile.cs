using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class Tile
    {
        // Tiling Texture
        private Texture2D texture;
        // How many tiles wide
        private int tileCountWidth = 8;
        // How many tiles high
        private int tileCountHeight = 8;
        // Rectangle to draw tiles in
        private Rectangle targetRectangle;
        // Position to draw the tiled Rectangle at
        private Vector2 t_position;
        private Vector2 r_position;

        public Tile(Vector2 relative_position, Vector2 type_position)
        {
            this.r_position = relative_position;
            this.t_position = type_position;
        }

        public void LoadContent(ContentManager Content, Viewport viewport)
        {
            // Load the texture to tile.
            texture = Content.Load<Texture2D>("Outside");

            // Define a drawing rectangle based on the number of tiles wide and high, using the texture dimensions.
            t_position = new Vector2(48 * Convert.ToInt32(t_position.X), 48 * Convert.ToInt32(t_position.Y));
            targetRectangle = new Rectangle(0, 0, Convert.ToInt32(t_position.X) , Convert.ToInt32(t_position.Y) );


            // Center the rectangle on the screen, using both the screen center and the rectangle center.
            r_position = new Vector2(48 * Convert.ToInt32(r_position.X), 48 * Convert.ToInt32(r_position.Y));
        }
        public void Draw(SpriteBatch _spriteBatch)
        {
            _spriteBatch.Begin(SpriteSortMode.FrontToBack, BlendState.Opaque, SamplerState.LinearWrap, DepthStencilState.Default, RasterizerState.CullNone);
            _spriteBatch.Draw(texture, r_position, targetRectangle, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0);
            _spriteBatch.End();
        }
    }
}
