using RL.NET.Spaces;
using RL.NET.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace RL.NET.Core
{
    public interface IEnvironment<TAction, TObservation, TRender>
    {
        EnvMetadata Metadata { get; }

        (float, float) RewardRange { get; }

        Space ActionSpace { get; }

        Space ObservationSpace { get; }

        EnvironmentResult<TObservation> Step(TAction action);

        TObservation Reset();

        TRender Render(string mode = "human");

        List<int> Seed(int? seed = null);

        EnvironmentResult<TObservation> ComputeReward(TObservation achieved_goal, TObservation desired_goal, Dictionary<string, object> info);
    }
}
