using Microsoft.ML.OnnxRuntime.Tensors;
using System;
using System.ComponentModel.DataAnnotations;

namespace Intex2A.Models.PredictionModels
{
    public class ModelData
    {
        [Required]
        public float Depth { get; set; }
        [Required]
        public float FaceBundles { get; set; }
        [Required]
        public float SouthToHead { get; set; }
        [Required]
        public float SquareEastWest { get; set; }
        [Required]
        public float Goods { get; set; }
        [Required]
        public float WestToHead { get; set; }
        [Required]
        public float WestToFeet { get; set; }
        [Required]
        public float SouthToFeet { get; set; }
        [Required]
        public float NorthSouth_N { get; set; }
        [Required]
        public float EastWest_E { get; set; }
        [Required]
        public float EastWest_W { get; set; }
        [Required]
        public float Area_NE { get; set; }
        [Required]
        public float Area_SE { get; set; }
        [Required]
        public float Area_SW { get; set; }
        [Required]
        public float AgeAtDeath_A { get; set; }
        [Required]
        public float AgeAtDeath_C { get; set; }

        internal Tensor<T> AsTensor<T>()
        {
            throw new NotImplementedException();
        }

        public float AgeAtDeath_I { get; set; }
        public float AgeAtDeath_N { get; set; }

        public Tensor<float> AsTensor()
        {
            float[] data = new float[]
            {
            Depth, FaceBundles, SouthToHead, SquareEastWest, Goods, 
            WestToHead, WestToFeet, SouthToFeet, NorthSouth_N,
            EastWest_E, EastWest_W, Area_NE, Area_SE, Area_SW,
            AgeAtDeath_A, AgeAtDeath_C, AgeAtDeath_I, AgeAtDeath_N
            };
            int[] dimensions = new int[] { 1, 18 };
            return new DenseTensor<float>(data, dimensions);
        }
    }
}
