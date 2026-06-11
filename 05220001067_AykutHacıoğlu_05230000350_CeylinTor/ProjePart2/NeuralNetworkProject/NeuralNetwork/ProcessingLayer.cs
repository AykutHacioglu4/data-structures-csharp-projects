using System;


namespace NeuralNetworkProject.CustomNetwork
{
    public class ProcessingLayer
    {
        private int inputFeatureCount;
        private int neuronCount;
        public double[] Outputs { get; private set; }
        public double[,] WeightMatrix { get; private set; }
        private Random randomGenerator = new Random();

        public ProcessingLayer(int inputSize, int neuronSize)
        {
            this.inputFeatureCount = inputSize;
            this.neuronCount = neuronSize;
            Outputs = new double[neuronSize];
            WeightMatrix = new double[neuronSize, inputSize];

            // Ağırlıkları rastgele değerlerle başlatır
            for (int neuronIndex = 0; neuronIndex < neuronSize; neuronIndex++)
            {
                for (int inputIndex = 0; inputIndex < inputSize; inputIndex++)
                {
                    WeightMatrix[neuronIndex, inputIndex] = randomGenerator.NextDouble();
                }
            }
        }

        public double[] ComputeOutput(double[] inputFeatures)
        {
            for (int neuronIndex = 0; neuronIndex < neuronCount; neuronIndex++)
            {
                double weightedSum = 0;
                for (int featureIndex = 0; featureIndex < inputFeatureCount; featureIndex++)
                {
                    weightedSum += inputFeatures[featureIndex] * WeightMatrix[neuronIndex, featureIndex];
                }
                Outputs[neuronIndex] = ApplyActivationFunction(weightedSum);
            }
            return Outputs;
        }

        private double ApplyActivationFunction(double x)
        {
            return 1 / (1 + Math.Exp(-x)); // Sigmoid aktivasyon fonksiyonu
        }
    }
}
