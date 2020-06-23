using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aphelion.IO
{
    public static class Bindings
    {
        public static Keys MoveLeft => Keys.A;
        public static Keys MoveLeftAlt => Keys.Left;
        public static Keys MoveRight => Keys.D;
        public static Keys MoveRightAlt => Keys.Right;
        public static Keys MoveUp => Keys.W;
        public static Keys MoveUpAlt => Keys.Up;
        public static Keys MoveDown => Keys.S;
        public static Keys MoveDownAlt => Keys.Down;

        public static bool MovingLeft(InputManager input, PlayerIndex player)
        {
            return input.IsKeyDown(player, MoveLeft) ||
                input.IsKeyDown(player, MoveLeftAlt);
        }
        public static bool MovingRight(InputManager input, PlayerIndex player)
        {
            return input.IsKeyDown(player, MoveRight) ||
                input.IsKeyDown(player, MoveRightAlt);
        }
        public static bool MovingUp(InputManager input, PlayerIndex player)
        {
            return input.IsKeyDown(player, MoveUp) ||
                input.IsKeyDown(player, MoveUpAlt);
        }
        public static bool MovingDown(InputManager input, PlayerIndex player)
        {
            return input.IsKeyDown(player, MoveDown) ||
                input.IsKeyDown(player, MoveDownAlt);
        }
    }
}
