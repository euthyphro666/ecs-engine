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
    public class Player
    {
        public Mob Puppet;
        public int Speed;

        public Player(ContentManager assets)
        {
            var ship = assets.Load<Texture2D>("Ship");
            Puppet = new Mob(ship, 500, 500, 32, 32);
            Speed = 8;
        }

        public void Dispose()
        {
        }
    }
}
