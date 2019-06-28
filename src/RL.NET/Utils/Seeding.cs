using System;
using System.Collections.Generic;
using System.Text;

namespace RL.NET.Utils
{
    public class Seeding
    {
        public static RandomState GetState(int? seed = null)
        {
            if (seed.HasValue && seed <= 0)
                throw new ArgumentException("Seed must be a non-negative integer");

            if(!seed.HasValue)
                seed = CreateSeed();

            return new RandomState(seed);
        }

        private static int CreateSeed()
        {
            int seed = Guid.NewGuid().GetHashCode();
            if (seed < 0)
                seed = seed * -1;

            return seed;
        }
    }
}
