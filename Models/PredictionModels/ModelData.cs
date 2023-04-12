using Microsoft.ML.OnnxRuntime.Tensors;

namespace Intex2A.Models.PredictionModels
{
    public class ModelData
    {
        public float Depth { get; set; }
        public float FaceBundles { get; set; }
        public float SouthToHead { get; set; }
        public float SquareEastWest { get; set; }
        public float Goods { get; set; }
        public float WestToHead { get; set; }
        public float WestToFeet { get; set; }
        public float SouthToFeet { get; set; }
        public float NorthSouth_N { get; set; }
        public float EastWest_E { get; set; }
        public float EastWest_W { get; set; }
        public float Area_NE { get; set; }
        public float Area_SE { get; set; }
        public float Area_SW { get; set; }
        public float AgeAtDeath_A { get; set; }
        public float AgeAtDeath_C { get; set; }
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
