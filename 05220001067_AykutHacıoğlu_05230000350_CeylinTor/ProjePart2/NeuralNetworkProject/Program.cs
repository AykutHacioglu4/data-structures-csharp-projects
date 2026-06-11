using System;
using System.Collections.Generic;
using NeuralNetworkProject.CustomNetwork;

public class EntryPoint
{
    public static void Main(string[] args)
    {
        int featureSize = 25;  // 5x5 matris düz bir dizi olarak ele alınır
        int classCount = 2;    // İki çıktı sınıfı: "A" ve "B"
        double stepSize = 0.03; // Öğrenme oranı
        int iterationCount = 40; // Eğitim için kullanılacak iterasyon sayısı

        // Adım 1: Eğitim veri setini oluştur
        List<int[,]> dataClassA = DataGenerator.CreateClassA(10); // A sınıfı için 10 örnek oluştur
        List<int[,]> dataClassB = DataGenerator.CreateClassB(10); // B sınıfı için 10 örnek oluştur

        // Örnek verileri göster
        Console.WriteLine("Examples of Class A:");
        DataGenerator.ShowSampleData(dataClassA); // Sınıf A'ya ait örnekleri göster
        Console.WriteLine("\nExamples of Class B:");
        DataGenerator.ShowSampleData(dataClassB); // Sınıf B'ye ait örnekleri göster

        // Adım 2: Eğitim verilerini ve etiketlerini hazırla
        List<int[,]> inputData = new List<int[,]>();
        List<int> expectedLabels = new List<int>();

        foreach (var data in dataClassA)
        {
            inputData.Add(data);
            expectedLabels.Add(0); // Sınıf A için etiket 0
        }

        foreach (var data in dataClassB)
        {
            inputData.Add(data);
            expectedLabels.Add(1); // Sınıf B için etiket 1
        }

        // Adım 3: Sinir ağını başlat
        SimpleNeuralNet model = new SimpleNeuralNet(featureSize, classCount, stepSize);

        // Adım 4: Modeli eğit
        Console.WriteLine("Training the model...");
        model.TrainModel(inputData, expectedLabels, iterationCount);

        // Adım 5: Bilinen veriler üzerinde modeli değerlendir
        Console.WriteLine("\nEvaluating on training data...");
        model.Evaluate(inputData, expectedLabels);

        // Adım 6: Görülmemiş veriler üzerinde test et
        List<int[,]> unseenSamples = new List<int[,]>
        {
            new int[,] {
                { 0, 1, 0, 0, 0 },
                { 0, 1, 0, 0, 0 },
                { 1, 1, 1, 0, 0 },
                { 0, 1, 0, 0, 0 },
                { 0, 1, 0, 0, 0 }
            },
            new int[,] {
                { 0, 1, 0, 0, 0 },
                { 1, 1, 1, 0, 0 },
                { 0, 1, 0, 0, 0 },
                { 0, 1, 0, 0, 0 },
                { 1, 1, 1, 0, 0 }
            },
            new int[,] {
                { 0, 1, 1, 1, 0 },
                { 1, 0, 0, 0, 1 },
                { 0, 1, 1, 1, 0 },
                { 0, 1, 0, 0, 0 },
                { 0, 1, 1, 1, 0 }
            },
            new int[,] {
                { 1, 1, 1, 1, 0 },
                { 0, 0, 0, 1, 0 },
                { 1, 1, 1, 1, 1 },
                { 1, 0, 0, 0, 0 },
                { 1, 1, 1, 1, 0 }
            }
        };

        List<int> expectedLabelsUnseen = new List<int> { 0, 0, 1, 1 };

        Console.WriteLine("\nTesting on unseen samples...");
        model.Evaluate(unseenSamples, expectedLabelsUnseen);
    }
}
