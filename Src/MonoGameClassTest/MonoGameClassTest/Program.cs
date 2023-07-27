using System;

namespace MonoGameClassTest
{
#if WINDOWS || LINUX
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
                game.Run();
            using (var game = new Game2())
                game.Run();
            //System.Threading.ThreadPool.QueueUserWorkItem(game1);
            //System.Threading.ThreadPool.QueueUserWorkItem(game2);
        }
        private static void game1(object data)
        {
            using (var game = new Game1())
                game.Run();
        }
        private static void game2(object data)
        {
            using (var game = new Game2())
                game.Run();
        }
    }
#endif
}
