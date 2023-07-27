using System;
using System.IO;
using System.IO.IsolatedStorage;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace CursorTest
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        public const int WindowsWidth = 800;
        public const int WindowsHeight = 600;
        Texture2D LayoutBackGroundLvl2;
        Texture2D Spaceship;
        public double LayoutBackGroundLvl1PositionCount;
        public Vector2 SpaceshipPosition;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferWidth = 800;
            graphics.PreferredBackBufferHeight = 600;
            graphics.ToggleFullScreen();
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            FileStream filestreamLayoutBackGroundLvl2 = new FileStream("Content/LayoutBackGroundLvl2.png", FileMode.Open);
            LayoutBackGroundLvl2 = Texture2D.FromStream(GraphicsDevice, filestreamLayoutBackGroundLvl2);
            filestreamLayoutBackGroundLvl2.Dispose();
            FileStream filestreamSpaceship = new FileStream("Content/Spaceship.png", FileMode.Open);
            Spaceship = Texture2D.FromStream(GraphicsDevice, filestreamSpaceship);
            filestreamSpaceship.Dispose();
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            SpaceshipPosition.X = System.Windows.Forms.Cursor.Position.X;
            SpaceshipPosition.Y = System.Windows.Forms.Cursor.Position.Y;
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            // TODO: Add your drawing code here
            LayoutBackGroundLvl1PositionCount = LayoutBackGroundLvl1PositionCount + 1;
            spriteBatch.Begin();
            spriteBatch.Draw(LayoutBackGroundLvl2, new Rectangle(0, (int)LayoutBackGroundLvl1PositionCount, WindowsWidth, WindowsHeight), Color.White);
            spriteBatch.Draw(LayoutBackGroundLvl2, new Rectangle(0, (int)LayoutBackGroundLvl1PositionCount - WindowsHeight, WindowsWidth, WindowsHeight), Color.White);
            spriteBatch.Draw(Spaceship, new Rectangle((int)SpaceshipPosition.X, (int)SpaceshipPosition.Y, 70, 180), Color.White);
            spriteBatch.End();
            if (LayoutBackGroundLvl1PositionCount >= 600)
                LayoutBackGroundLvl1PositionCount = 0;
            base.Draw(gameTime);
        }
    }
}