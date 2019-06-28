using System;
using System.Collections.Generic;
using System.Text;

namespace RL.NET.Core
{
    public class ObservationWrapper<TAction, TObservation, TRender> : Wrapper<TAction, TObservation, TRender>
    {
        public ObservationWrapper(IEnvironment<TAction, TObservation, TRender> env) : base(env)
        {

        }

        public override EnvironmentResult<TObservation> Step(TAction action)
        {
            var result = base.Step(action);
            result.Observation = Observation(result.Observation);

            return result;
        }

        public virtual TObservation Observation(TObservation observation)
        {
            return observation;
        }

    }
}
