using Aphelion.Domain;
using Aphelion.Events;
using Aphelion.Graphics;
using Aphelion.IO;
using Aphelion.Systems;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aphelion.Contracts
{
    public interface ISystem : IDisposable
    {
        public SType Type { get; }
        public bool FixedTick { get; }
        public void RegisterEvents(EventManager events);
        public void Tick(LevelManager level, InputManager input, ScreenManager screen);
    }
}
