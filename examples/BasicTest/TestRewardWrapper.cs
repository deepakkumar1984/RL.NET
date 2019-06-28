using RL.NET.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicTest
{
    public class TestRewardWrapper : RewardWrapper<float, float, float[]>
    {
        public TestRewardWrapper(IEnvironment<float, float, float[]> env) : base(env)
        {
        }

        public override float Reward(float reward)
        {
            return reward * 2;
        }
    }
}
