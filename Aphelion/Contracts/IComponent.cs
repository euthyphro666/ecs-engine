using Aphelion.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aphelion.Contracts
{
    public interface IComponent : IDisposable
    {
        public CType Type { get; }
    }
}
