using System;
using System.Collections.Generic;
using System.Linq;

namespace NeuralNetworkProject.CustomNetwork
{
    public class SimpleNeuralNet
    {
        private int featureSize;   // Giriş özelliklerinin boyutu (örneğin, 5x5 matris için 25)
        private int classCount;    // Çıkış sınıf sayısı (örneğin, 2: A ve B)
        private double stepSize;   // Öğrenme oranı
        private double[] weights;  // Ağırlıklar (tek katmanlı bir model için)
        private Random random;

        public SimpleNeuralNet(int featureSize, int classCount, double stepSize)
        {
            if (classCount <= 0 || featureSize <= 0)
                throw new ArgumentException("Feature size and class count must be greater than 0.");

            this.featureSize = featureSize;
            this.classCount = classCount;
            this.stepSize = stepSize;

            // Ağırlıkları rastgele başlat
            weights = new double[featureSize];
            random = new Random();
            for (int i = 0; i < featureSize; i++)
            {
                weights[i] = random.NextDouble() - 0.5; // -0.5 ile 0.5 arasında
            }
        }

        // Modelin eğitimi için metod
        public void TrainModel(List<int[,]> inputs, List<int> labels, int iterations)
        {
            if (inputs.Count != labels.Count)
                throw new ArgumentException("Input and label counts must match.");

            for (int iter = 0; iter < iterations; iter++)
            {
                for (int i = 0; i < inputs.Count; i++)
                {
                    // Giriş verisini düzleştir
                    var input = FlattenMatrix(inputs[i]);
                    var prediction = Predict(input);
                    var error = labels[i] - prediction;

                    // Ağırlıkları güncelle
                    for (int j = 0; j < weights.Length; j++)
                    {
                        weights[j] += stepSize * error * input[j];
                    }
                }
                Console.WriteLine($"Iteration {iter + 1}/{iterations} completed.");
            }
        }

        // Tahmin yapma metod
        public int Predict(int[] input)
        {
            double score = 0;
            for (int i = 0; i < weights.Length; i++)
            {
                score += weights[i] * input[i];
            }

            // Sınıf tahmini: 0 (A) veya 1 (B)
            return score >= 0 ? 1 : 0;
        }

        // Modeli değerlendirme metodu
        public void Evaluate(List<int[,]> inputs, List<int> labels)
        {
            if (inputs.Count != labels.Count)
                throw new ArgumentException("Input and label counts must match.");

            int correctCount = 0;
            for (int i = 0; i < inputs.Count; i++)
            {
                var input = FlattenMatrix(inputs[i]);
                var prediction = Predict(input);

                if (prediction == labels[i])
                    correctCount++;
            }

            double accuracy = (double)correctCount / labels.Count * 100;
            Console.WriteLine($"Accuracy: {accuracy:F2}%");
        }

        // 2D matrisi tek boyutlu diziye dönüştürme metodu
        private int[] FlattenMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[] flatArray = new int[rows * cols];
            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    flatArray[index++] = matrix[i, j];
                }
            }

            return flatArray;
        }
    }
}
