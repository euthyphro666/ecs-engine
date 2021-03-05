using Aphelion.Game.States;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aphelion.Game
{
    /// <summary>
    /// Top level management of all services provided to the Game by the Provider.
    /// </summary>
    public class Manager : IStateMachine
    {

        public Provider ActiveProvider;
        public IState ActiveState;

        public Manager()
        {
        }

        public void Start()
        {
            ActiveState = new TitleState();
            ActiveProvider = new Provider()
            {

            };
        }

        public void ProgressState()
        {
            switch(ActiveState.Id)
            {
                case 0:
                    ActiveState = new QuitState();
                break;
            };
        }

        public void RegressState()
        {
            switch (ActiveState.Id)
            {
                case 0:
                    ActiveState = new QuitState();
                break;
            };
        }

        public void Update()
        {
            ActiveState.Update();
        }

        public void Render()
        {
            ActiveState.Render();
        }
    }
}
