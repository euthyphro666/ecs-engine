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
using Aphelion.Systems;

namespace Aphelion.Screens
{
    public class GameScreen : IManager
    {

        private ContentManager Assets;
        private LevelManager Level;
        private EventManager Events;

        private Dictionary<SType, ISystem> Systems;

        public GameScreen(ContentManager assets, EventManager events)
        {
            Assets = assets;
            Events = events;

            Level = new LevelManager(assets);
            Systems = new Dictionary<SType, ISystem>();
            InitSystems();
        }

        private void InitSystems()
        {
            Systems[SType.Physics] = new SPhysics();
            Systems[SType.Controller] = new SController();
        }

        public void Update(GameTime delta, InputManager input)
        {
            Level.Update(delta, input);
        }

        public void Render(GameTime delta, ScreenManager screen)
        {
            Level.Render(delta, screen);
        }

        public void Dispose()
        {
        }
    }
}
