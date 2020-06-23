using Aphelion.Contracts;
using Aphelion.Domain;
using Aphelion.Events;
using Aphelion.Graphics;
using Aphelion.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aphelion.Systems
{
    public class SPhysics : ISystem
    {
        public SType Type => SType.Physics;

        public void RegisterEvents(EventManager events)
        {
        }

        public void Update(LevelManager level, InputManager input, ScreenManager screen)
        {
            // Player
            var body = level.Player.Puppet;
            body.Step();
            body.Dx *= 0.1f;
            body.Dy *= 0.1f;
        }
    }
}
