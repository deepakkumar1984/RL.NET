using System;
using System.Collections.Generic;
using System.Text;

namespace RL.NET.Core
{
    public class EnvironmentResult<T>
    {
        public T Observation { get; set; }

        public float Reward { get; set; }

        public bool Done { get; set; }

        public Dictionary<string, object> Info { get; set; }

        public EnvironmentResult()
        {
            Info = new Dictionary<string, object>();
        }
    }
}
