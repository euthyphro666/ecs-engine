using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aphelion.Events.Args;
using Aphelion.IO;

namespace Aphelion.Events
{
    public class EventManager
    {

        public event EventHandler<InputEventArgs> InputEvent;
        public void OnInputEvent(object sender, InputEventArgs e)
        {
            InputEvent?.Invoke(sender, e);
        }

        public event EventHandler<ChangeStateEventArgs> ChangeStateEvent;
        public void OnChangeStateEvent(object sender, ChangeStateEventArgs e)
        {
            ChangeStateEvent?.Invoke(sender, e);
        }

        public event EventHandler<StringEventArgs> LoggingEvent;
        public void OnLoggingEvent(object sender, StringEventArgs e)
        {
            LoggingEvent?.Invoke(sender, e);
        }

        public event EventHandler<StringEventArgs> StartGameRequestEvent;
        public void OnStartGameRequestEvent(object sender, StringEventArgs e)
        {
            StartGameRequestEvent?.Invoke(sender, e);
        }

        public event EventHandler<EventArgs> ConnectSuccessEvent;
        public void OnConnectSuccessEvent(object sender)
        {
            ConnectSuccessEvent?.Invoke(sender, EventArgs.Empty);
        }

    }
}