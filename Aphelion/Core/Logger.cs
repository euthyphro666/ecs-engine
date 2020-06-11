using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aphelion.Events;

namespace Aphelion.Core
{
    public static class Logger
    {
        public static EventManager Events;

        public static void Log(string msg)
        {
            Events.OnLoggingEvent(null, new StringEventArgs(msg));
        }
    }
}