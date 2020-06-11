using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Aphelion.Contracts;
using Aphelion.Graphics;
using Aphelion.IO;
using Microsoft.Xna.Framework.Content;
using Aphelion.Events;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Aphelion.Domain;

namespace Aphelion.Screens
{
    public class GameScreen : IManager
    {

        private ContentManager Assets;
        private EventManager Events;
        private Level CurrentLevel;

        public GameScreen(ContentManager assets, EventManager events)
        {
            Assets = assets;
            Events = events;

            CurrentLevel = new Level(assets);
        }
        public void Update(GameTime delta, InputManager input)
        {
            CurrentLevel.Update(delta, input);
        }

        public void Render(GameTime delta, ScreenManager screen)
        {
            CurrentLevel.Render(delta, screen);
        }

        public void Dispose()
        {
        }
    }
}
