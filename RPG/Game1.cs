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
    public class Game1 : Game
    {
        protected GraphicsDeviceManager _graphics;
        protected SpriteBatch _spriteBatch;
        PC player;
        Tile tile;
        List<Tile> tiles = new List<Tile>();

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            player = new PC("Player", 100, 0, 10, 10, 10, 10);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            for (int i = 0; i <= 16; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    tiles.Add(new Tile(new Vector2(i, j), new Vector2(1,1)));
                }
            }
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            // Get the drawable area of the screen.
            Viewport viewport = GraphicsDevice.Viewport;
            // TODO: use this.Content to load your game content here
            foreach (Tile tile in tiles)
            {
                tile.LoadContent(Content, viewport);
            }
            player.texture = Content.Load<Texture2D>("PC");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            foreach(Tile tile in tiles)
            {
                tile.Draw(_spriteBatch);
            }
            

            base.Draw(gameTime);
        }
    }
}
