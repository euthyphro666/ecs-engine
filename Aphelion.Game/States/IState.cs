using System;
using System.Collections.Generic;
using System.Text;

namespace Aphelion.Game.States
{
    public interface IState
    {
        int Id { get; }
        void Update();
        void Render();
    }
}
