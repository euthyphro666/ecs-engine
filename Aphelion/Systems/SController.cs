using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Aphelion.Contracts;
using Aphelion.Domain;
using Aphelion.Events;
using Aphelion.Graphics;
using Aphelion.IO;

namespace Aphelion.Systems
{
    public class SController : ISystem
    {
        public SType Type => SType.Controller;
        public bool FixedTick => true;

        public void RegisterEvents(EventManager events)
        {
        }

        public void Tick(LevelManager level, InputManager input, ScreenManager screen)
        {
            var up = Bindings.MovingUp(input, PlayerIndex.One);
            var down = Bindings.MovingDown(input, PlayerIndex.One);
            var left = Bindings.MovingLeft(input, PlayerIndex.One);
            var right = Bindings.MovingRight(input, PlayerIndex.One);

            // Move player and camera simultaneously
            if(up)
            {
                var speed = level.Player.Speed;
                if (down)
                {
                    level.Player.Puppet.Dy += speed;
                }
                if (up)
                {
                    level.Player.Puppet.Dy -= speed;
                }
                if (left)
                {
                    level.Player.Puppet.Dx -= speed;
                }
                if (right)
                {
                    level.Player.Puppet.Dx += speed;
                }
            }
        }

        public void Dispose()
        {

        }
    }
}
