using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using RL.NET.Utils;
using SuperchargedArray;

namespace RL.NET.Spaces
{
    public abstract class Space
    {
        public long[] Shape { get; set; }

        public DType DataType { get; set; }

        public RandomState RandomState { get; set; }

        protected ArrayOps K = Global.OP;

        public Space(long[] shape, DType dtype = DType.Single)
        {
            Shape = shape;
            DataType = dtype;
        }

        public virtual void Seed(int? seed = null)
        {
            RandomState = Seeding.GetState(seed);
        }

        public abstract SuperArray Sample();

        public abstract bool Contains(SuperArray x);

        public virtual string ToJson(params SuperArray[] sample_n)
        {
            SpaceSamples samples = new SpaceSamples();
            foreach (var item in sample_n)
            {
                samples.Samples.Add(SampleArray.FromArray(item));
            }

            return Newtonsoft.Json.JsonConvert.SerializeObject(samples, Newtonsoft.Json.Formatting.Indented);
        }

        public virtual SuperArray[] FromJson(string sample_n)
        {
            var samples = Newtonsoft.Json.JsonConvert.DeserializeObject<SpaceSamples>(sample_n);
            List<SuperArray> result = new List<SuperArray>();

            foreach (var item in samples.Samples)
            {
                result.Add(item.ToArray());
            }

            return result.ToArray();
        }
    }
}
