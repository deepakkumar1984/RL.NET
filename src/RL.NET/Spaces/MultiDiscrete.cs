
using System;
using System.Collections.Generic;
using System.Text;
using SuperchargedArray;

namespace RL.NET.Spaces
{
    public class MultiDiscrete : Space
    {
        public MultiDiscrete(long[] shape, DType dtype = DType.Single) : base(shape, dtype)
        {
        }

        public override bool Contains(SuperArray x)
        {
            throw new NotImplementedException();
        }

        public override SuperArray Sample()
        {
            throw new NotImplementedException();
        }
    }
}
