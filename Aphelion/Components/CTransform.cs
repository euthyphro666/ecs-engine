using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Aphelion.Contracts;

namespace Aphelion.Components
{
    public class CTransform : IComponent
    {
        // IComponent
        public CType Type => CType.Transform;
        public void Dispose() { }

        // CTransform
        public Vector2 Position;
        public Vector2 Scale;
        public float Rotation;

        public CTransform() : this(0, 0, 1f, 1f) { }

        public CTransform(float x, float y, float w, float h)
        {
            Position = new Vector2(x, y);
            Scale = new Vector2(w, h);
            Rotation = 0f;
        }
    }
}
