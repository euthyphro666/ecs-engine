using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aphelion.Graphics;
using Aphelion.Contracts;
using Aphelion.Components;

namespace Aphelion.Domain
{
    public abstract class Entity
    {

        public Guid Id;
        private Dictionary<CType, IComponent> Components;

        public Entity()
        {
            Id = Guid.NewGuid();
            Components = new Dictionary<CType, IComponent>();
            this[CType.Transform] = new CTransform();
        }

        public IComponent this[CType type]
        {
            get
            {
                return Components.TryGetValue(type, out var result) 
                    ? result : default;
            }
            set
            {
                if(Components.TryGetValue(type, out var result))
                {
                    result.Dispose();
                    Components.Remove(type);
                }
                Components.Add(type, value);
            }
        }

        public T GetComponent<T>() where T : IComponent
        {
            return typeof(T).Name switch
            {
                nameof(CTransform) => (T)this[CType.Transform],
                _ => default
            };
        }



    }
}
