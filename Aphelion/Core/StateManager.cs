using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Aphelion.Contracts;
using Aphelion.Events;
using Aphelion.Events.Args;
using Aphelion.Graphics;
using Aphelion.Domain;
using Aphelion.IO;
using Aphelion.Screens;

namespace Aphelion.Core
{
    public class StateManager : IManager
    {
        private ContentManager Assets;
        private EventManager Events;

        private MenuScreen Menu;
        private GameScreen Game;
        //public TittyLoading Load;
        //public TittyDebugger Debug;

        public IManager State;

        public StateManager(ContentManager assets, EventManager events)
        {
            Assets = assets;
            Events = events;


            //Debug = new TittyDebugger(Assets, Events);
            //Menu = new TittyMenu(Assets, Events);
            Game = new GameScreen(assets, events);
            State = Game;

        }

        public void SwitchState(States state)
        {
            //switch (state)
            //{
            //    case States.Menu:
            //        State = Menu;
            //        break;
            //    case States.Loading:
            //        State = new TittyLoading(Assets, Events);
            //        break;
            //    case States.Game:
            //        State = Game;
            //        break;
            //}
        }

        public void Update(GameTime delta, InputManager input)
        {
            State?.Update(delta, input);
        }

        public void Render(GameTime delta, ScreenManager screen)
        {
            State?.Render(delta, screen);
            //Debug.Render(delta, screen);
        }

        public void Dispose()
        {
            State?.Dispose();
            //Debug.Dispose();
        }
    }
    public enum States
    {
        Menu,
        Loading,
        Game
    }
}
