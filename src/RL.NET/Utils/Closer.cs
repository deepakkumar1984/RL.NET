using System;
using System.Collections.Generic;
using System.Text;

namespace RL.NET.Utils
{
    public abstract class Closer : IDisposable
    {
        private object _objlock;
        private int nextId;
        private Dictionary<int, ICloseable> closeables;

        public Closer()
        {
            _objlock = new object();
            nextId = -1;

            closeables = new Dictionary<int, ICloseable>();
        }

        public void Dispose()
        {
            foreach (var item in closeables)
            {
                item.Value.Close();
            }
        }

        public int GenerateNextID()
        {
            lock (_objlock)
            {
                nextId += 1;
                return nextId;
            }
        }

        public int Register(ICloseable closeable)
        {
            nextId = GenerateNextID();
            closeables[nextId] = closeable;
            return nextId;
        }

        public void Unregister(int id)
        {
            if(closeables.ContainsKey(id))
                closeables.Remove(id);
        }
    }
}
