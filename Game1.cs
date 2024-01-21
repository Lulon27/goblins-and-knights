using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TestGame.Animation;
using TestGame.Rendering;

namespace TestGame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D _test;
        private Level _level;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            base.Initialize();
            _level = new Level();
            var e = new Entity();
            e.Position = new Vector2(0, 0);
            e.SpriteSheet = SpriteSheets.Knight.SpriteSheet;
            _level.AddEntity(e);
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            SpriteSheets.Init();
            SpriteSheets.Load(Content);
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        static int i = 0;
        protected override void Draw(GameTime gameTime)
        {
            i++;   
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            _level.Draw(_spriteBatch, gameTime);
            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
