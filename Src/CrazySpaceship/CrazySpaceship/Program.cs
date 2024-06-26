﻿using System;

namespace CrazySpaceship
{
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var game = new Game1())
            {
                //((System.Windows.Forms.Form)System.Windows.Forms.Form.FromHandle(game.Window.Handle)).Icon = new System.Drawing.Icon("CrazySpaceship.ico");
                game.Run();
            }
        }
    }
}
