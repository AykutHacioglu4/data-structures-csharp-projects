using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Şehirlerin isimlerini tutan dizi
        string[] cities = { "", "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Amasya", "Ankara", "Antalya",
                            "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur",
                            "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne",
                            "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane",
                            "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir", "Kars", "Kastamonu",
                            "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya",
                            "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu",
                            "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat",
                            "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray",
                            "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır",
                            "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce" };

        // Şehirlerin komşularını temsil eden bir sözlük (dictionary)
        var neighbors = new Dictionary<int, List<int>>
{
    { 1, new List<int> { 31, 33, 38, 46, 51, 80 } },
    { 2, new List<int> { 21, 27, 44, 46, 63 } },
    { 3, new List<int> { 15, 20, 26, 32, 42, 43, 64 } },
    { 4, new List<int> { 13, 25, 36, 49, 65, 76 } },
    { 5, new List<int> { 19, 55, 60, 66 } },
    { 6, new List<int> { 14, 18, 26, 40, 42, 68, 71 } },
    { 7, new List<int> { 15, 32, 33, 42, 48, 70 } },
    { 8, new List<int> { 25, 53, 75 } },
    { 9, new List<int> { 20, 35, 45, 48 } },
    { 10, new List<int> { 16, 17, 35, 43, 45 } },
    { 11, new List<int> { 43, 26, 14, 54, 16 } },
    { 12, new List<int> { 21, 49, 25, 24, 62, 23 } },
    { 13, new List<int> { 56, 65, 4, 49, 72 } },
    { 14, new List<int> { 26, 6, 18, 67, 81, 54, 11, 78 } },
    { 15, new List<int> { 48, 7, 32, 3, 20 } },
    { 16, new List<int> { 10, 43, 11, 54, 41, 77 } },
    { 17, new List<int> { 10, 59, 22 } },
    { 18, new List<int> { 6, 71, 19, 37, 14, 78 } },
    { 19, new List<int> { 66, 5, 55, 57, 37, 18, 71 } },
    { 20, new List<int> { 48, 15, 3, 64, 45, 9 } },
    { 21, new List<int> { 63, 47, 72, 49, 12, 23, 44, 2 } },
    { 22, new List<int> { 17, 59, 39 } },
    { 23, new List<int> { 21, 12, 62, 24, 44 } },
    { 24, new List<int> { 23, 62, 12, 25, 69, 29, 28, 58, 44 } },
    { 25, new List<int> { 12, 49, 4, 36, 75, 8, 53, 69, 24 } },
    { 26, new List<int> { 3, 42, 6, 14, 11, 43 } },
    { 27, new List<int> { 79, 63, 2, 46, 80, 31 } },
    { 28, new List<int> { 29, 61, 24, 58, 52 } },
    { 29, new List<int> { 24, 69, 61, 28 } },
    { 30, new List<int> { 65, 73 } },
    { 31, new List<int> { 27, 80, 1 } },
    { 32, new List<int> { 7, 42, 3, 15 } },
    { 33, new List<int> { 1, 51, 42, 70, 7 } },
    { 34, new List<int> { 41, 59, 39 } },
    { 35, new List<int> { 9, 45, 10 } },
    { 36, new List<int> { 4, 76, 75, 25 } },
    { 37, new List<int> { 19, 57, 18, 74, 78 } },
    { 38, new List<int> { 1, 46, 58, 66, 50, 51 } },
    { 39, new List<int> { 22, 59, 34 } },
    { 40, new List<int> { 50, 66, 71, 6, 68 } },
    { 41, new List<int> { 77, 34, 16, 54 } },
    { 42, new List<int> { 7, 70, 33, 51, 68, 6, 26, 3, 32 } },
    { 43, new List<int> { 45, 64, 3, 26, 11, 16, 10 } },
    { 44, new List<int> { 46, 2, 21, 23, 24, 58 } },
    { 45, new List<int> { 35, 9, 20, 64, 43, 10 } },
    { 46, new List<int> { 27, 2, 44, 58, 38, 1, 80 } },
    { 47, new List<int> { 63, 21, 72, 56, 73 } },
    { 48, new List<int> { 7, 15, 20, 9 } },
    { 49, new List<int> { 21, 72, 13, 4, 25, 12 } },
    { 50, new List<int> { 51, 38, 66, 40, 68 } },
    { 51, new List<int> { 50, 38, 1, 33, 42, 68 } },
    { 52, new List<int> { 55, 58, 60, 28 } },
    { 53, new List<int> { 8, 25, 69, 61 } },
    { 54, new List<int> { 81, 14, 11, 16, 41 } },
    { 55, new List<int> { 57, 19, 5, 60, 52 } },
    { 56, new List<int> { 47, 13, 65, 72, 73 } },
    { 57, new List<int> { 19, 37, 55 } },
    { 58, new List<int> { 46, 38, 44, 24, 28, 52, 60, 66 } },
    { 59, new List<int> { 17, 34, 39, 22 } },
    { 60, new List<int> { 58, 52, 55, 5, 66 } },
    { 61, new List<int> { 53, 69, 29, 28 } },
    { 62, new List<int> { 23, 12, 24 } },
    { 63, new List<int> { 27, 2, 21, 47 } },
    { 64, new List<int> { 45, 20, 3, 43 } },
    { 65, new List<int> { 30, 73, 56, 13, 4 } },
    { 66, new List<int> { 38, 58, 60, 5, 19, 71, 40, 50 } },
    { 67, new List<int> { 74, 14, 81, 78 } },
    { 68, new List<int> { 51, 50, 40, 6, 42 } },
    { 69, new List<int> { 24, 25, 53, 61, 29 } },
    { 70, new List<int> { 33, 42, 7 } },
    { 71, new List<int> { 40, 66, 19, 18, 6 } },
    { 72, new List<int> { 47, 13, 49, 21, 56 } },
    { 73, new List<int> { 47, 56, 65, 30 } },
    { 74, new List<int> { 37, 67, 78 } },
    { 75, new List<int> { 36, 25, 8 } },
    { 76, new List<int> { 4, 36 } },
    { 77, new List<int> { 41, 16 } },
    { 78, new List<int> { 37, 67, 74, 14, 18 } },
    { 79, new List<int> { 27 } },
    { 80, new List<int> { 31, 27, 46, 1 } },
    { 81, new List<int> { 54, 14, 67 } }
};

        // Mesafe matrisini oluştur
        int[][] distanceMatrix = new int[82][];
        for (int i = 0; i < 82; i++)
        {
            distanceMatrix[i] = new int[82];
        }

        int[][] distanceMatrixFirst = new int[82][];
        for (int i = 0; i < 82; i++)
        {
            distanceMatrixFirst[i] = new int[82];
        }

        // Mesafe verilerini CSV dosyasından okuyun
        ReadCitiesDistances("distances.csv", distanceMatrix); // Bu da kodda kullanmak için oluşturduğumuz matrixi düzelttiğimiz metot

        ReadCitiesDistancesJagged("distances.csv", distanceMatrixFirst); // Üçgen şeklinde olan Jagged Array i çektiğimiz metot

        PrintJaggedArray(distanceMatrixFirst);

        

        // Rastgele şehir çiftlerinin mesafelerini yazdıran metodu çağırın
        PrintRandomCityDistances(cities, distanceMatrix);

        // 1. Mesafe matrisini kopyala
        int[][] distanceMatrixCopy = new int[distanceMatrix.Length][];
        for (int i = 0; i < distanceMatrix.Length; i++)
        {
            distanceMatrixCopy[i] = (int[])distanceMatrix[i].Clone();
        }

        // Komşu olmayan şehirler arasındaki mesafeleri sonsuz olarak ayarlayan metodu çağırın
        SetInfiniteDistancesForNonNeighbors(distanceMatrixCopy, neighbors);
        PrintDistanceMatrix(distanceMatrixCopy);

        string districtsFile = "districts.txt";
        string neighborsDistrictsFile = "districtNeighbors.csv";
        string distancesDistrictsFile = "districtDistances.csv";

        // İlçeleri dosyadan alır ve bir diziye ekler
        string[] districts = GetDistricts(districtsFile);

        // Komşulukları dosyadan okur ve bir dictionary'ye ekler
        Dictionary<int, List<int>> neighborsDistricts = GetNeighbors(neighborsDistrictsFile);

        // Mesafeleri dosyadan okur ve bir matrise ekler
        int[,] distanceMatrixDistricts = new int[30, 30];

        ReadDistrictsDistances(distancesDistrictsFile, distanceMatrixDistricts);

        PrintDistanceMatrixDistricts(distanceMatrixDistricts);

        CalculateNonNeighborDistances(cities, distanceMatrix, distanceMatrixCopy, neighbors);

        

        CalculateNonNeighborDistancesForDistricts(districts, distanceMatrixDistricts, neighborsDistricts);


        

        Console.ReadLine();
    }

    static void PrintRandomCityDistances(string[] cities, int[][] distanceMatrix)
    {
        Console.WriteLine("Rastgele seçilen şehir çiftlerinin mesafeleri:");
        Random rand = new Random();

        for (int i = 0; i < 10; i++)
        {
            int city1 = rand.Next(1, 82);
            int city2 = rand.Next(1, 82);

            while (city1 == city2)
            {
                city2 = rand.Next(1, 82);
            }

            string cityName1 = cities[city1];
            string cityName2 = cities[city2];
            int distance = distanceMatrix[city1][city2];

            Console.WriteLine($"{cityName1} ({city1}) - {cityName2} ({city2}): {distance} km");
        }
    }

    static void SetInfiniteDistancesForNonNeighbors(int[][] distanceMatrix, Dictionary<int, List<int>> neighbors)
    {
        for (int i = 1; i < 82; i++)
        {
            for (int j = 1; j < 82; j++)
            {
                if (i != j && (!neighbors.ContainsKey(i) || !neighbors[i].Contains(j)))
                {
                    distanceMatrix[i][j] = int.MaxValue; // Sonsuz
                }
            }
        }
    }

    static void PrintDistanceMatrix(int[][] distanceMatrix)
    {
        Console.WriteLine("İllerin Uzaklık Matrixinin Komşu İllere Göre Düzenlenmesi Sonrası:");
        for (int i = 1; i < 82; i++)
        {
            for (int j = 1; j < 82; j++)
            {
                Console.Write(distanceMatrix[i][j] == int.MaxValue ? "INF " : distanceMatrix[i][j] + " ");
            }
            Console.WriteLine();
        }
    }



    static void CalculateNonNeighborDistances(string[] cities, int[][] distanceMatrix, int[][] distanceMatrixCopy, Dictionary<int, List<int>> neighbors)
    {
        StreamWriter fileOut = new StreamWriter("1.c.2.txt");
        fileOut.AutoFlush = true;
        Console.SetOut(fileOut);
        int n = distanceMatrix.Length;
        List<(string cityPair, int calculatedDistance, int predefinedDistance, int difference)> results = new List<(string, int, int, int)>();

        int minDifference = int.MaxValue;
        int maxDifference = int.MinValue;
        List<string> minDifferencePairs = new List<string>();
        List<string> maxDifferencePairs = new List<string>();

        for (int i = 1; i < n; i++)
        {
            for (int j = 1; j < n; j++)
            {
                if (i != j && (!neighbors.ContainsKey(i) || !neighbors[i].Contains(j)))
                {
                    int calculatedDistance = DijkstraReturn(distanceMatrixCopy, i, j);
                    int predefinedDistance = distanceMatrix[i][j];
                    int difference = Math.Abs(calculatedDistance - predefinedDistance);

                    results.Add(($"{cities[i]} ({i}) - {cities[j]} ({j})", calculatedDistance, predefinedDistance, difference));

                    // Min farkı güncelle
                    if (difference < minDifference)
                    {
                        minDifference = difference;
                        minDifferencePairs.Clear(); // Önceki çiftleri temizle
                        minDifferencePairs.Add($"{cities[i]} ({i}) - {cities[j]} ({j})");
                    }
                    else if (difference == minDifference)
                    {
                        minDifferencePairs.Add($"{cities[i]} ({i}) - {cities[j]} ({j})");
                    }

                    // Max farkı güncelle
                    if (difference > maxDifference)
                    {
                        maxDifference = difference;
                        maxDifferencePairs.Clear(); // Önceki çiftleri temizle
                        maxDifferencePairs.Add($"{cities[i]} ({i}) - {cities[j]} ({j})");
                    }
                    else if (difference == maxDifference)
                    {
                        maxDifferencePairs.Add($"{cities[i]} ({i}) - {cities[j]} ({j})");
                    }
                }
            }
        }
        // Sonuçları yazdır
        Console.WriteLine("\nKomşu olmayan şehir çiftleri arası mesafeler:");
        foreach (var result in results)
        {
            Console.WriteLine($"{result.cityPair}: Tanımlanan = {result.predefinedDistance} km, Hesaplanan = {result.calculatedDistance} km, Fark = {result.difference} km");
        }

        // Min ve max farkları yazdır
        Console.WriteLine($"\nEn küçük fark: {minDifference} km, Şehir çiftleri:");
        foreach (var pair in minDifferencePairs)
        {
            Console.WriteLine(pair);
        }

        Console.WriteLine($"\nEn büyük fark: {maxDifference} km, Şehir çiftleri:");
        foreach (var pair in maxDifferencePairs)
        {
            Console.WriteLine(pair);
        }

        
    }




    static void ReadCitiesDistances(string file, int[][] distanceMatrix)
    {
        // CSV dosyasını oku
        var lines = File.ReadAllLines(file);
        int row = 1;

        foreach (var line in lines)
        {
            string[] values = line.Split(',');

            // Mesafeleri matrix'e ekle
            for (int col = 1; col <= values.Length; col++)
            {
                int distance = int.Parse(values[col - 1].Trim());
                distanceMatrix[row][col] = distance;
            }
            row++;
        }
    }

    static void ReadCitiesDistancesJagged(string file, int[][] distanceMatrix)
    {
        // CSV dosyasını oku
        var lines = File.ReadAllLines(file);

        // Jagged array her bir satırı ayrı olarak başlatılmalı
        for (int row = 1; row <= lines.Length; row++) // 1'den başlayarak satırları oku
        {
            string[] values = lines[row - 1].Split(','); // Satırı CSV formatında ayır

            // Satır için array başlat, her satırdaki sütun sayısı satır numarasına bağlı olarak belirlenir
            distanceMatrix[row] = new int[row]; // Satırda row sayısı kadar sütun olacak (üst üçgen)

            for (int col = 1; col < row; col++) // 1'den başlayarak sütunları oku (üçgenin üst kısmı)
            {
                // Mesafeyi doğru pozisyona yerleştir
                distanceMatrix[row][col] = int.Parse(values[col - 1].Trim());
            }
        }

        
    }

    static void PrintJaggedArray(int[][] distanceMatrix)
    {
        Console.WriteLine("İllerin Uzaklık Matrixi:");
        for (int i = 0; i < distanceMatrix.Length; i++)
        {
            for (int j = 0; j < distanceMatrix[i].Length; j++)
            {
                Console.Write(distanceMatrix[i][j] + "\t");  // Elemanları aralarına tab koyarak yazdır
            }
            Console.WriteLine();  // Satır sonunda yeni satıra geç
        }
    }
    static int DijkstraReturn(int[][] distanceMatrix, int startCity, int targetCity)
    {
        int n = distanceMatrix.Length;
        int[] distances = new int[n];
        bool[] visited = new bool[n];

        // Initialize distances as infinity
        for (int i = 1; i < n; i++)
        {
            distances[i] = int.MaxValue;
        }
        distances[startCity] = 0;

        for (int i = 1; i < n; i++)
        {
            int a = MinDistance(distances, visited);
            if (a == -1) break; // If no valid city is found, exit
            visited[a] = true;

            for (int v = 1; v < n; v++)
            {
                if (!visited[v] && distanceMatrix[a][v] != int.MaxValue && distances[a] != int.MaxValue &&
                    distances[a] + distanceMatrix[a][v] < distances[v])
                {
                    distances[v] = distances[a] + distanceMatrix[a][v];
                }
            }
        }

        return distances[targetCity];
    }

    static int MinDistance(int[] distances, bool[] visited)
    {
        int min = int.MaxValue, minIndex = -1;

        for (int v = 1; v < distances.Length; v++)
        {
            if (!visited[v] && distances[v] < min)
            {
                min = distances[v];
                minIndex = v;
            }
        }

        return minIndex;
    }
    // İlçeleri dosyadan alır ve bir diziye ekler
    // Method to get districts from the file and add to an array
    static string[] GetDistricts(string filePath)
    {
        List<string> districts = new List<string>();
        try
        {
            foreach (var line in File.ReadLines(filePath))
            {
                string district = line.Trim();  // Clean whitespace from line
                if (!string.IsNullOrEmpty(district))
                {
                    districts.Add(district);  // Add non-empty district to the list
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading districts file: {ex.Message}");
        }
        return districts.ToArray();  // Convert list to array
    }



    // Komşulukları dosyadan okur ve bir dictionary'ye ekler
    static Dictionary<int, List<int>> GetNeighbors(string filePath)
    {
        Dictionary<int, List<int>> neighbors = new Dictionary<int, List<int>>();
        try
        {
            int lineIndex = 0;  // İlçenin indeksini 0'dan başlatıyoruz

            foreach (var line in File.ReadLines(filePath))
            {
                var splitLine = line.Trim().Split(',');

                // Key olarak satırın indeksini alıyoruz (ilçe numarası, 0'dan başlıyor)
                int key = lineIndex;

                // Komşu ilçeleri almak için liste oluşturuyoruz
                List<int> neighborList = new List<int>();

                // Eğer satırda komşular varsa, bunları listeye ekliyoruz
                for (int i = 0; i < splitLine.Length; i++)
                {
                    // Komşu ilçeleri (yani satırdaki her değeri) listeye ekliyoruz
                    neighborList.Add(int.Parse(splitLine[i].Trim()));
                }

                // Dictionary'ye key ve komşularını ekliyoruz
                neighbors[key] = neighborList;

                lineIndex++;  // Bir sonraki satırın indeksini artırıyoruz
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Dosya okuma hatası: {ex.Message}");
        }

        return neighbors;
    }


    // Mesafeleri dosyadan okur ve matrix'i doldurur
    static void ReadDistrictsDistances(string file, int[,] distanceMatrixDistricts)
    {
        // CSV dosyasını oku
        var lines = File.ReadAllLines(file);

        // Satırları okurken, distanceMatrixDistricts'teki satırları ve sütunları dolduruyoruz
        int row = 0;  // Satırları 0'dan başlatıyoruz

        foreach (var line in lines)
        {
            // Satırı virgülle ayır ve boşlukları temizle
            string[] values = line.Split(',');

            // Satırdaki her bir mesafeyi matrix'e ekle
            for (int col = 0; col < values.Length; col++) // Kolon indeksine dikkat et (0'dan başlar)
            {
                // Mesafeyi al ve diziye ekle
                int distance;
                if (int.TryParse(values[col].Trim(), out distance)) // Parse işlemi için TryParse kullanıyoruz
                {
                    // Dizinin indeksleri 0'dan başlıyor
                    distanceMatrixDistricts[row, col] = distance;
                }
                else
                {
                    Console.WriteLine($"Geçersiz mesafe değeri: {values[col]}");
                }
            }
            row++;
        }
    }

    static void PrintDistanceMatrixDistricts(int[,] distanceMatrix)
    {
        Console.WriteLine("İlçelerin Uzaklık Matrixi:");
        for (int i = 0; i < 30; i++)  // 30x30'luk matris için i ve j 0'dan başlar
        {
            for (int j = 0; j < 30; j++)
            {
                Console.Write(distanceMatrix[i, j] == int.MaxValue ? "INF " : distanceMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }



    static int DijkstraReturnDistricts(int[,] distanceMatrix, int startCity, int targetCity)
    {
        int n = distanceMatrix.GetLength(0);
        int[] distances = new int[n];
        bool[] visited = new bool[n];

        // Tüm mesafeleri sonsuz olarak başlat
        for (int i = 0; i < n; i++)
        {
            distances[i] = int.MaxValue;
        }
        distances[startCity] = 0;

        for (int i = 0; i < n; i++)
        {
            int a = MinDistanceDistricts(distances, visited);
            if (a == -1) break; // Eğer geçerli bir şehir bulunamazsa çıkış yap
            visited[a] = true;

            for (int v = 0; v < n; v++)
            {
                if (!visited[v] && distanceMatrix[a, v] != int.MaxValue && distances[a] != int.MaxValue &&
                    distances[a] + distanceMatrix[a, v] < distances[v])
                {
                    distances[v] = distances[a] + distanceMatrix[a, v];
                }
            }
        }

        return distances[targetCity];
    }

    static int MinDistanceDistricts(int[] distances, bool[] visited)
    {
        int min = int.MaxValue, minIndex = -1;

        for (int v = 0; v < distances.Length; v++)
        {
            if (!visited[v] && distances[v] < min)
            {
                min = distances[v];
                minIndex = v;
            }
        }

        return minIndex;
    }


        static void CalculateNonNeighborDistancesForDistricts(string[] districts, int[,] distanceMatrixDistricts, Dictionary<int, List<int>> neighborsDistricts)
    {
        StreamWriter fileOut = new StreamWriter("1.e.2.txt");
        fileOut.AutoFlush = true;
        Console.SetOut(fileOut);
        int n = distanceMatrixDistricts.GetLength(0);  // n = 30
        List<(string districtPair, int calculatedDistanceDistricts, int predefinedDistanceDistricts, int differenceDistricts)> resultsDistricts =
            new List<(string, int, int, int)>();

        int minDifferenceDistricts = int.MaxValue;
        int maxDifferenceDistricts = int.MinValue;
        List<string> minDifferencePairsDistricts = new List<string>();
        List<string> maxDifferencePairsDistricts = new List<string>();

        for (int i = 0; i < n; i++) // 0'dan başla
        {
            for (int j = 0; j < n; j++)
            {
                // İlçe kendisiyle kıyaslanmasın
                if (i != j && (!neighborsDistricts.ContainsKey(i) || !neighborsDistricts[i].Contains(j)))
                {
                    // Dijkstra algoritmasını kullanarak her iki şehir arasındaki mesafeyi hesapla
                    int calculatedDistanceDistricts = DijkstraReturnDistricts(distanceMatrixDistricts, i , j);
                    int predefinedDistanceDistricts = distanceMatrixDistricts[i, j];


                    // Mesafeler geçerli ise farkı hesapla
                    if (calculatedDistanceDistricts < int.MaxValue && predefinedDistanceDistricts < int.MaxValue)
                    {
                        int differenceDistricts = Math.Abs(calculatedDistanceDistricts - predefinedDistanceDistricts);
                        resultsDistricts.Add(($"{districts[i]} ({i}) - {districts[j]} ({j})", calculatedDistanceDistricts, predefinedDistanceDistricts, differenceDistricts));

                        // En küçük farkı güncelle
                        if (differenceDistricts < minDifferenceDistricts)
                        {
                            minDifferenceDistricts = differenceDistricts;
                            minDifferencePairsDistricts.Clear();
                            minDifferencePairsDistricts.Add($"{districts[i]} ({i}) - {districts[j]} ({j})");
                        }
                        else if (differenceDistricts == minDifferenceDistricts)
                        {
                            minDifferencePairsDistricts.Add($"{districts[i]} ({i}) - {districts[j]} ({j})");
                        }

                        // En büyük farkı güncelle
                        if (differenceDistricts > maxDifferenceDistricts)
                        {
                            maxDifferenceDistricts = differenceDistricts;
                            maxDifferencePairsDistricts.Clear();
                            maxDifferencePairsDistricts.Add($"{districts[i]} ({i}) - {districts[j]} ({j})");
                        }
                        else if (differenceDistricts == maxDifferenceDistricts)
                        {
                            maxDifferencePairsDistricts.Add($"{districts[i]} ({i}) - {districts[j]} ({j})");
                        }
                    }
                }
            }
        }

        // Sonuçları yazdır
        Console.WriteLine("\nKomşu olmayan ilçeler arasındaki mesafeler:");
        foreach (var result in resultsDistricts)
        {
            Console.WriteLine($"{result.districtPair}: Tanımlı = {result.predefinedDistanceDistricts} km, Hesaplanan = {result.calculatedDistanceDistricts} km, Fark = {result.differenceDistricts} km");
        }

        // En küçük ve en büyük farkları yazdır
        Console.WriteLine($"\nEn küçük fark: {minDifferenceDistricts} km, İlçeler:");
        foreach (var pair in minDifferencePairsDistricts)
        {
            Console.WriteLine(pair);
        }

        Console.WriteLine($"\nEn büyük fark: {maxDifferenceDistricts} km, İlçeler:");
        foreach (var pair in maxDifferencePairsDistricts)
        {
            Console.WriteLine(pair);
        }
    }
}