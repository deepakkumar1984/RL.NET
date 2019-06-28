using System;
using System.Collections.Generic;
using System.Text;

namespace RL.NET.Core
{
    public class ActionWrapper<TAction, TObservation, TRender> : Wrapper<TAction, TObservation, TRender>
    {
        public ActionWrapper(IEnvironment<TAction, TObservation, TRender> env) : base(env)
        {

        }

        public override EnvironmentResult<TObservation> Step(TAction action)
        {
            return base.Step(Action(action));
        }

        public virtual TAction Action(TAction action)
        {
            return action;
        }

        public virtual TAction ReverseAction(TAction action)
        {
            return action;
        }
    }
}
