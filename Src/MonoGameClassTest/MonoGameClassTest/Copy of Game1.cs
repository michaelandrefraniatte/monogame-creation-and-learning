using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGameClassTest
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Level
    {
        int i = 0;
        float elapsed;
        public void Update(GameTime gameTime)
        {
            i = i + 1;
            // TODO: Add your update logic here
            elapsed = (float)gameTime.ElapsedGameTime.TotalMilliseconds;
        }
    }
}
