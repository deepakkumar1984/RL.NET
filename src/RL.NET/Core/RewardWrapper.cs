using System;
using System.Collections.Generic;
using System.Text;

namespace RL.NET.Core
{
    public abstract class RewardWrapper<TAction, TObservation, TRender> : Wrapper<TAction, TObservation, TRender>
    {
        public RewardWrapper(IEnvironment<TAction, TObservation, TRender> env) : base(env)
        {

        }

        public override EnvironmentResult<TObservation> Step(TAction action)
        {
            var result = base.Step(action);
            result.Reward = Reward(result.Reward);

            return result;
        }

        public virtual float Reward(float reward)
        {
            return reward;
        }
    }
}
