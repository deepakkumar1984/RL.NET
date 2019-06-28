using SuperchargedArray;
using System;
using System.Collections.Generic;
using System.Text;

namespace RL.NET.Spaces
{
    public class SpaceSamples
    {
        public SpaceSamples()
        {
            Samples = new List<SampleArray>();
        }

        public List<SampleArray> Samples { get; set; }
    }

    public class SampleArray
    {
        public long[] Shape { get; set; }

        public DType DataType { get; set; }

        public float[] Data { get; set; }

        public static SampleArray FromArray(SuperArray x)
        {
            SampleArray result = new SampleArray()
            {
                Data = x.Data<float>(),
                Shape = x.Shape,
                DataType = x.ElementType
            };

            return result;
        }

        public SuperArray ToArray()
        {
            SuperArray result = new SuperArray(Shape, DataType);
            result.LoadFrom(Data);

            return result;
        }
    }
}
