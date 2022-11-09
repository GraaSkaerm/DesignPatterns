using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructualPatterns.CompositPattern
{
    internal class Composit : IComponent
    {
        private List<IComponent> _components = new List<IComponent>();

        public void Add(IComponent component)
        {
            _components.Add(component);
        }

        public List<IComponent> GetComponents<T>() where T : IComponent
        {
            List<IComponent> components = new List<IComponent>();

            foreach (var i in _components)
            {
                if (i.GetType() == typeof(T))
                {
                    components.Add(i);
                }
            }

            return components;
        }

        public IComponent GetComponent<T>() where T : IComponent
        {
            foreach (var i in _components)
            {
                if (i.GetType() == typeof(T))
                {
                    return i;
                }
            }

            return null;
        }

        public void Remove<T>() where T : IComponent
        {
            var type = typeof(T);

            for (int i = 0; i < _components.Count; i++)
            {
                if (type == _components[i].GetType())
                {
                    _components.Remove(_components[i]);
                    return;
                }
            }
        
        }

        public void OnExecute()
        {
            foreach (var i in _components)
            {
                i.OnExecute();
            }
        }
    }
}
