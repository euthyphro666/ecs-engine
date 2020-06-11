using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aphelion.Domain
{
    public class Mob : Entity
    {
        public Mob(Texture2D spr, float x, float y, int w, int h) : base(spr, x, y, w, h) { }
    }
}
