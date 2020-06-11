﻿using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace Aphelion.IO
{

    public class Controls
    {

        public PlayerIndex Player;
        public bool UsingGamePad;

        public Controls(bool usingGamepad, PlayerIndex player)
        {
            Player = player;
            UsingGamePad = usingGamepad;
        }
    }
}
