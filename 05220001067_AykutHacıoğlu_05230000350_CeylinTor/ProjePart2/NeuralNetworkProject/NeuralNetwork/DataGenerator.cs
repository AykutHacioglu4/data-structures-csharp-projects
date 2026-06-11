using System;
using System.Collections.Generic;

namespace NeuralNetworkProject.CustomNetwork
{
    public static class DataGenerator
    {
        private static Random randomizer = new Random();

        // A sınıfı matrislerinin farklı varyasyonlarını oluşturur
        public static List<int[,]> CreateClassA(int sampleCount)
        {
            List<int[,]> classADataset = new List<int[,]>();

            for (int i = 0; i < sampleCount; i++)
            {
                int[,] sampleA = {
                { 0, 1, 0, 0, 0 },
                { 0, 1, 0, 0, 0 },
                { 0, 1, 0, 0, 0 },
                { 0, 1, 0, 0, 0 },
                { 0, 1, 0, 0, 0 }
            };

                // A sınıfı yapısına bir temel ekler
                if (randomizer.Next(0, 2) == 1)
                {
                    sampleA[4, 0] = 1;
                    sampleA[4, 1] = 1;
                    sampleA[4, 2] = 1;
                }

                // B sınıfı yapısına kalınlık ekler
                if (randomizer.Next(0, 2) == 1)
                {
                    for (int row = 0; row < 5; row++)
                    {
                        if (sampleA[row, 1] == 1) sampleA[row, 2] = 1;
                    }
                }

                classADataset.Add(sampleA);
            }

            return classADataset;
        }

        // B sınıfı matrislerinin farklı varyasyonlarını oluşturur
        public static List<int[,]> CreateClassB(int sampleCount)
        {
            List<int[,]> classBDataset = new List<int[,]>();

            for (int i = 0; i < sampleCount; i++)
            {
                int[,] sampleB = {
                { 0, 1, 1, 1, 0 },
                { 0, 0, 0, 1, 0 },
                { 0, 1, 1, 1, 0 },
                { 0, 1, 0, 0, 0 },
                { 0, 1, 1, 1, 0 }
            };

                // Kenarları değişken hale getirir
                if (randomizer.Next(0, 2) == 1) sampleB[0, 0] = 1; // Üst-sol
                if (randomizer.Next(0, 2) == 1) sampleB[0, 4] = 1; // Üst-sağ
                if (randomizer.Next(0, 2) == 1) sampleB[4, 4] = 1; // Alt-sağ
                if (randomizer.Next(0, 2) == 1) sampleB[4, 0] = 1; // Alt-sol

                // İç kısımlara varyasyonlar ekler
                if (randomizer.Next(0, 2) == 1) sampleB[1, 4] = 1; // Sağ kenar
                if (randomizer.Next(0, 2) == 1) sampleB[2, 4] = 1; // Sağ orta
                if (randomizer.Next(0, 2) == 1) sampleB[2, 0] = 1; // Sol orta
                if (randomizer.Next(0, 2) == 1) sampleB[3, 0] = 1; // Alt-sol

                classBDataset.Add(sampleB);
            }

            return classBDataset;
        }

        // Örnek verileri görüntüler
        public static void ShowSampleData(List<int[,]> dataset)
        {
            int displayCount = Math.Min(dataset.Count, 10); // Maksimum 10 örnek görüntüler

            for (int i = 0; i < displayCount; i++)
            {
                Console.WriteLine($"Example {i + 1}:");
                int[,] matrix = dataset[i];
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }

}
