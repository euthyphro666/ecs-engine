using Aphelion.Contracts;
using Aphelion.Systems;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aphelion.Core
{
    public class Engine
    {
        private Dictionary<SType, ISystem> Systems;
        public ISystem this[SType type]
        {
            get
            {
                return Systems.TryGetValue(type, out var result)
                    ? result : default;
            }
            set
            {
                if (Systems.TryGetValue(type, out var result))
                {
                    result.Dispose();
                    Systems.Remove(type);
                }
                Systems.Add(type, value);
            }
        }

        public Engine()
        {
            Systems = new Dictionary<SType, ISystem>();

            Systems[SType.Controller] = new SController();
            Systems[SType.Physics] = new SPhysics();
        }
    }
}
