using RL.NET.Core;
using RL.NET.Spaces;
using RL.NET.Utils;
using System;

namespace BasicTest
{
    class Program
    {
        static void Main(string[] args)
        {

            TestEnv env = new TestEnv();
            var render = env.Render();
            var step = env.Step(2);

            var wrap = new TestRewardWrapper(env);
            var reward = wrap.Reward(2);

            Console.ReadLine();
        }
    }
}
