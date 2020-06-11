using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aphelion.Maths
{
    public class Circle
    {
        public Vector2 Position;
        public float Radius;

        public float X
        {
            get => Position.X;
            set => Position.X = value;
        }
        public float Y
        {
            get => Position.Y;
            set => Position.Y = value;
        }

        public Circle(float x, float y, float r)
        {
            Position = new Vector2(x, y);
            Radius = r;
        }

        public bool IsCollided(Circle c)
        {
            var dist = Utility.Distance2(Position, c.Position);
            var rad = (c.Radius * c.Radius) + (2 * c.Radius * Radius) + (Radius * Radius);
            return dist < rad;
        }

        public void CalculateRebound(Circle body, ref Vector2 force)
        {
            var magnitude = force.Length();
            force.X = X - body.X;
            force.Y = Y - body.Y;
            force.Normalize();
            force *= magnitude;
        }

        /// <summary>
        /// Takes two corners defining a boundary and determines if the circle is within that boundary.
        /// </summary>
        /// <param name="v0">Corner pin one</param>
        /// <param name="v1">Corner pin two</param>
        /// <returns></returns>
        public bool IsInBounds(Vector2 v0, Vector2 v1)
        {
            var x0 = v0.X < v1.X ? v0.X : v1.X;
            var x1 = v0.X < v1.X ? v1.X : v0.X;
            var y0 = v0.Y < v1.Y ? v0.Y : v1.Y;
            var y1 = v0.Y < v1.Y ? v1.Y : v0.Y;

            var outOfBounds = false;
            outOfBounds |= Position.X - Radius < x0;
            outOfBounds |= Position.X + Radius > x1;
            outOfBounds |= Position.Y - Radius < y0;
            outOfBounds |= Position.Y + Radius > y1;
            return outOfBounds;
        }
    }
}