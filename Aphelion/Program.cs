using Aphelion.Core;
using System;

namespace Aphelion
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new Master())
            {
                game.IsFixedTimeStep = true;
                game.Run();
            }
        }
    }
}
