using System;
using System.Collections.Generic;
using System.Text;
using RL.NET.Spaces;

namespace RL.NET.Core
{
    public class Wrapper<TAction, TObservation, TRender> : IEnvironment<TAction, TObservation, TRender>
    {
        public EnvMetadata Metadata { get; set; }
        public (float, float) RewardRange { get; set; }
        public Space ActionSpace { get; set; }
        public Space ObservationSpace { get; set; }

        private IEnvironment<TAction, TObservation, TRender> environment;

        public Wrapper(IEnvironment<TAction, TObservation, TRender> env)
        {
            environment = env;
        }

        public EnvironmentResult<TObservation> ComputeReward(TObservation achieved_goal, TObservation desired_goal, Dictionary<string, object> info)
        {
            return environment.ComputeReward(achieved_goal, desired_goal, info);
        }

        public TRender Render(string mode = "human")
        {
            return environment.Render(mode);
        }

        public TObservation Reset()
        {
            return environment.Reset();
        }

        public List<int> Seed(int? seed = null)
        {
            return environment.Seed(seed);
        }

        public virtual EnvironmentResult<TObservation> Step(TAction action)
        {
            return environment.Step(action);
        }
    }
}
