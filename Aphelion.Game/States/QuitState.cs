using System;
using System.Collections.Generic;
using System.Text;

namespace Aphelion.Game.States
{
    public class QuitState : IState
    {
        public int Id => -1;

        public void Update()
        {
            Environment.Exit(0);
        }

        public void Render() { }
    }
}
