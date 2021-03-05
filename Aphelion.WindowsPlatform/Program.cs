using Aphelion.Game;
using System;

namespace Aphelion.WindowsPlatform
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new Bootstrapper())
                game.Run();
        }
    }
}
