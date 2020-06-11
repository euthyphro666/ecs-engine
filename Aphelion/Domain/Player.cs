using Aphelion.Contracts;
using Aphelion.Graphics;
using Aphelion.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aphelion.Domain
{
    public class Player : IManager
    {
        public Mob Puppet;
        private int Speed;

        public Player(ContentManager assets)
        {
            var ship = assets.Load<Texture2D>("Ship");
            Puppet = new Mob(ship, 500, 500, 32, 32);
            Speed = 8;
        }

        public void Update(GameTime delta, InputManager input)
        {
            var up = input.IsKeyDown(PlayerIndex.One, Keys.W);
            var down = input.IsKeyDown(PlayerIndex.One, Keys.S);
            var left = input.IsKeyDown(PlayerIndex.One, Keys.A);
            var right = input.IsKeyDown(PlayerIndex.One, Keys.D);

            if (down)
            {
                Puppet.Y += Speed;
            }
            if (up)
            {
                Puppet.Y -= Speed;
            }
            if (left)
            {
                Puppet.X -= Speed;
            }
            if (right)
            {
                Puppet.X += Speed;
            }
        }
        public void Render(GameTime delta, ScreenManager screen)
        {
            Puppet.Render(screen);
        }

        public void Dispose()
        {
        }
    }
}
