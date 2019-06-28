using System;
using System.Collections.Generic;
using System.Text;
using SuperchargedArray;

namespace RL.NET
{
    public class RandomState
    {
        public int? Seed { get; set; }

        private ArrayOps K = Global.OP;

        public RandomState(int? seed = null)
        {
            Seed = seed;
        }

        public SuperArray Normal(float mean, float stdv, long[] shape, DType dtype)
        {
            SuperArray x = new SuperArray(shape, dtype);
            K.RandomNormal(x, mean, stdv, Seed);

            return x;
        }

        public SuperArray Uniform(float low, float high, long[] shape, DType dtype)
        {
            SuperArray x = new SuperArray(shape, dtype);
            K.RandomUniform(x, low, high, Seed);

            return x;
        }

        public SuperArray Bernoulli(float p, long[] shape, DType dtype)
        {
            SuperArray x = new SuperArray(shape, dtype);
            K.RandomBernoulli(x, p, Seed);

            return x;
        }

        public SuperArray Cauchy(float median, float sigma, long[] shape, DType dtype)
        {
            SuperArray x = new SuperArray(shape, dtype);
            K.RandomCauchy(x, median, sigma, Seed);

            return x;
        }

        public SuperArray Exponential(float lambda, long[] shape, DType dtype)
        {
            SuperArray x = new SuperArray(shape, dtype);
            K.RandomExponential(x, lambda, Seed);

            return x;
        }

        public SuperArray Geometric(float p, long[] shape, DType dtype)
        {
            SuperArray x = new SuperArray(shape, dtype);
            K.RandomGeometric(x, p, Seed);

            return x;
        }

        public SuperArray LogNormal(float mean, float stdv, long[] shape, DType dtype)
        {
            SuperArray x = new SuperArray(shape, dtype);
            K.RandomLogNormal(x, mean, stdv, Seed);

            return x;
        }

    }
}
