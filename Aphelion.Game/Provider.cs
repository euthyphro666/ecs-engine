using Aphelion.Game.Audios;
using Aphelion.Game.Connections;
using Aphelion.Game.Graphics;
using Aphelion.Game.Inputs;
using Aphelion.Game.Settings;
using Aphelion.Game.States;

namespace Aphelion.Game
{
    /// <summary>
    /// Provides the abstract interfaces that the game will use to iteract with core level services. 
    /// (i.e. sound, input, graphics, settings, connection, assets, 
    /// </summary>
    public class Provider
    {
        public readonly IAudio Audio;
        public readonly IConnection Connection;
        public readonly IGraphic Graphic;
        public readonly IInput Input;
        public readonly ISetting Setting;
        public readonly IStateMachine State;
    }
}
