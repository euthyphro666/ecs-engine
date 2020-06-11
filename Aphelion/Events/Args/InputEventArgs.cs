using Aphelion.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aphelion.Events.Args
{
    public class InputEventArgs : EventArgs
    {
        public InputState State { get; set; }
        public Guid RoomId { get; set; }
    }
}
