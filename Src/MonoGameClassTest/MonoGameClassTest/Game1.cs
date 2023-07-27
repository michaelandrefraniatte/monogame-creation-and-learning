using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGameClassTest
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        Level level;
        GraphicsDeviceManager graphics;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            this.TargetElapsedTime = System.TimeSpan.FromSeconds(1.0f / 1000.0f);
        }
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            level = new Level();
            base.Initialize();
        }
        protected override void Update(GameTime gameTime)
        {
            // TODO: Add your update logic here

            level.Update(gameTime);
            base.Update(gameTime);
        }
    }
}
