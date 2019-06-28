using RL.NET.Core;
using RL.NET.Spaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BasicTest
{
    public class TestEnv : IEnvironment<float, float, float[]>
    {
        public EnvMetadata Metadata
        {
            get
            {
                return new EnvMetadata()
                {
                    RenderModes = new string[] { "human", "ai" }
                };
            }
        }

        public (float, float) RewardRange { get; }
        public Space ActionSpace { get; }
        public Space ObservationSpace { get;  }

        public EnvironmentResult<float> ComputeReward(float achieved_goal, float desired_goal, Dictionary<string, object> info)
        {
            throw new NotImplementedException();
        }

        public float Render(string mode = "human")
        {
            return 1;
        }

        public float Reset()
        {
            throw new NotImplementedException();
        }

        public List<int> Seed(int? seed = null)
        {
            throw new NotImplementedException();
        }

        public EnvironmentResult<float> Step(float action)
        {
            return new EnvironmentResult<float>()
            {
                Done = false,
                Observation = 3,
                Reward = 5
            };
        }

        float[] IEnvironment<float, float, float[]>.Render(string mode)
        {
            throw new NotImplementedException();
        }
    }
}
