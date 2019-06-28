using System;
using System.Collections.Generic;
using System.Text;
using SuperchargedArray;

namespace RL.NET.Spaces
{
    public class Box : Space
    {
        public float Low { get; set; }

        public float High { get; set; }

        public Box(float low, float high, long[] shape = null, DType dtype = DType.Single) : base(shape, dtype)
        {
            if(shape == null)
            {
                Shape = new long[] { 1};
            }

            Low = low;
            High = high;
        }

        public override bool Contains(SuperArray x)
        {
            return (x.Shape.Length == Shape.Length && K.Mean(x >= Low) == 1 && K.Mean(x <= High) == 1);
        }

        public override SuperArray Sample()
        {
            return RandomState.Uniform(Low, High, Shape, DataType);
        }

        public override string ToString()
        {
            return "Box (" + String.Join(",", Shape) + ")";
        }
    }
}
