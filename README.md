# Data Structures Projects in C#

## English

This repository contains two C# projects developed to apply data structures, graph algorithms, matrix-based processing, file handling, and basic classification logic in practical scenarios.

The first project focuses on road distance analysis between cities and districts. It uses matrix-based graph representation and Dijkstra's shortest path algorithm to calculate and compare shortest distances.

The second project implements a simple custom neural-network-style classifier for binary pattern recognition. It works with 5x5 matrix inputs, converts them into feature vectors, and classifies them using a manually implemented training and prediction workflow.

These projects were built to understand how core computer science concepts behave when they are applied to structured data, graph problems, and basic machine learning-style classification tasks.

---

## Projects Included

### 1. Road Distance and Shortest Path Analysis

This project analyzes road distance data between Turkish cities and İzmir districts. Distance data is read from external files, stored in matrix-based structures, and processed as a graph.

The application uses Dijkstra's algorithm to calculate the shortest paths between locations. It compares predefined distance values with calculated shortest-path results and writes the output to result files.

The main purpose of this project is to show how graph representation and shortest path algorithms can be applied to real-world-like road distance data.

#### Main Features

* Reads city and district distance data from external files
* Stores distance values using arrays and matrices
* Represents locations as graph nodes
* Uses neighborhood relationships for graph traversal
* Applies Dijkstra's shortest path algorithm
* Compares existing distance values with calculated shortest paths
* Writes calculated results to output files

#### Concepts Used

* Arrays
* Matrices
* Jagged arrays
* Dictionaries
* File I/O
* Graph representation
* Dijkstra's shortest path algorithm

---

### 2. Custom Neural Network for Binary Pattern Recognition

This project implements a simple custom classifier in C# without using external machine learning libraries. The application classifies 5x5 binary matrix patterns into predefined categories.

The dataset is generated programmatically by creating variations of binary patterns. Each matrix is converted into a one-dimensional feature vector and processed by a custom neural-network-style structure.

The purpose of this project is to understand the basic workflow behind data generation, feature extraction, training, weight updates, prediction, and evaluation.

#### Main Features

* Generates synthetic 5x5 binary pattern data
* Represents image-like inputs using two-dimensional arrays
* Converts matrix data into one-dimensional feature vectors
* Implements a basic classifier from scratch
* Uses iterative weight updates during training
* Tests the model with both training and unseen samples
* Displays prediction and accuracy results through the console

#### Concepts Used

* Object-oriented programming
* Matrix processing
* Feature vector creation
* Basic classification logic
* Manual training workflow
* Custom neural-network-style implementation

---

## Technologies Used

* C#
* .NET Framework
* .NET 8
* Visual Studio
* Object-Oriented Programming
* File Processing
* Data Structures
* Graph Algorithms
* Basic Machine Learning Logic

---

## What I Implemented and Learned

Through these projects, I practiced applying data structures and algorithms to problems that involve real data organization, graph traversal, and classification.

In the shortest path project, I worked with external data files, matrix-based graph representation, and Dijkstra's algorithm. This helped me understand how location data can be modeled as a graph and how shortest path calculations can be performed using weighted connections.

In the binary pattern classification project, I implemented the core parts of a simple classifier manually. I practiced generating input data, converting matrix patterns into feature vectors, updating weights during training, and evaluating predictions.

Main topics I practiced:

* Reading and processing external files
* Structuring data with arrays, matrices, and dictionaries
* Representing real-world-like distance data as a graph
* Applying Dijkstra's algorithm
* Working with matrix-based input data
* Creating feature vectors from binary patterns
* Implementing a basic classifier without external ML libraries
* Organizing code with object-oriented programming principles

---

# C# ile Veri Yapıları Projeleri

## Türkçe

Bu repository, veri yapıları, graf algoritmaları, matris tabanlı veri işleme, dosya okuma/yazma işlemleri ve temel sınıflandırma mantığını pratik senaryolar üzerinde uygulayan iki ayrı C# projesini içermektedir.

İlk proje, şehirler ve ilçeler arasındaki karayolu mesafelerini analiz eder. Matris tabanlı graf temsili ve Dijkstra en kısa yol algoritması kullanılarak mesafeler hesaplanır ve karşılaştırılır.

İkinci proje, binary pattern recognition için basit bir özel sınıflandırıcı yapısı içerir. 5x5 matris girdileri feature vector yapısına dönüştürülür ve manuel olarak yazılmış eğitim/tahmin akışıyla sınıflandırılır.

Bu projeler, temel bilgisayar bilimi konularının yapılandırılmış veri, graf problemleri ve temel makine öğrenmesi benzeri sınıflandırma işlemlerinde nasıl uygulanabileceğini anlamak için geliştirilmiştir.

---

## Projeler

### 1. Karayolları Uzaklık ve En Kısa Yol Analizi

Bu proje, Türkiye’deki şehirler ve İzmir ilçeleri arasındaki karayolu mesafelerini analiz eder. Mesafe verileri harici dosyalardan okunur, matris tabanlı yapılarda saklanır ve graf olarak işlenir.

Uygulama, lokasyonlar arasındaki en kısa yolları Dijkstra algoritması ile hesaplar. Dosyalarda bulunan mevcut mesafe değerleri ile hesaplanan en kısa yol sonuçları karşılaştırılır ve sonuçlar çıktı dosyalarına yazdırılır.

Bu projenin temel amacı, graf temsili ve en kısa yol algoritmalarının gerçekçi karayolu mesafe verileri üzerinde nasıl uygulanabileceğini göstermektir.

#### Temel Özellikler

* Şehir ve ilçe mesafe verilerini harici dosyalardan okuma
* Mesafe değerlerini dizi ve matris yapılarıyla saklama
* Lokasyonları graf düğümleri olarak temsil etme
* Komşuluk ilişkileri üzerinden graf dolaşımı yapma
* Dijkstra algoritması ile en kısa yol hesaplama
* Mevcut mesafe değerleri ile hesaplanan en kısa yolları karşılaştırma
* Hesaplanan sonuçları çıktı dosyalarına yazdırma

#### Kullanılan Kavramlar

* Diziler
* Matrisler
* Jagged array yapısı
* Dictionary veri yapısı
* Dosya okuma/yazma işlemleri
* Graf temsili
* Dijkstra en kısa yol algoritması

---

### 2. Binary Pattern Recognition için Özel Sınıflandırıcı

Bu proje, herhangi bir harici makine öğrenmesi kütüphanesi kullanılmadan C# ile yazılmış basit bir özel sınıflandırıcı yapısını içerir. Uygulama, 5x5 boyutundaki binary matrisleri önceden tanımlanmış sınıflara ayırır.

Veri seti, binary pattern varyasyonları program içinde oluşturularak üretilir. Her matris tek boyutlu feature vector yapısına dönüştürülür ve özel olarak yazılmış sinir ağı benzeri yapı tarafından işlenir.

Bu projenin amacı, veri üretimi, feature extraction, eğitim, ağırlık güncelleme, tahmin ve değerlendirme adımlarının temel çalışma mantığını anlamaktır.

#### Temel Özellikler

* 5x5 binary pattern verileri üretme
* Görsel benzeri girdileri iki boyutlu dizilerle temsil etme
* Matris verilerini tek boyutlu feature vector yapısına dönüştürme
* Sıfırdan basit bir sınıflandırıcı yapısı oluşturma
* Eğitim sırasında iteratif ağırlık güncellemeleri yapma
* Modeli hem eğitim verileri hem de daha önce görmediği test örnekleriyle deneme
* Tahmin ve doğruluk sonuçlarını konsol üzerinden gösterme

#### Kullanılan Kavramlar

* Nesne yönelimli programlama
* Matris işleme
* Feature vector oluşturma
* Temel sınıflandırma mantığı
* Manuel eğitim akışı
* Özel sinir ağı benzeri yapı implementasyonu

---

## Kullanılan Teknolojiler

* C#
* .NET Framework
* .NET 8
* Visual Studio
* Nesne Yönelimli Programlama
* Dosya İşleme
* Veri Yapıları
* Graf Algoritmaları
* Temel Makine Öğrenmesi Mantığı

---

## Bu Projede Ne Uyguladım ve Ne Öğrendim?

Bu projelerde, veri yapıları ve algoritmaları gerçek veri organizasyonu, graf dolaşımı ve sınıflandırma problemleri üzerinde uyguladım.

En kısa yol projesinde harici veri dosyaları, matris tabanlı graf temsili ve Dijkstra algoritması ile çalıştım. Bu sayede lokasyon verilerinin graf olarak nasıl modellenebileceğini ve ağırlıklı bağlantılar üzerinden en kısa yol hesaplamalarının nasıl yapılacağını uyguladım.

Binary pattern sınıflandırma projesinde ise basit bir sınıflandırıcının temel parçalarını manuel olarak oluşturdum. Veri üretimi, matrisleri feature vector yapısına dönüştürme, eğitim sırasında ağırlık güncelleme ve tahmin sonuçlarını değerlendirme konularında pratik yaptım.

Bu projelerde pratik yaptığım ana konular:

* Harici dosyalardan veri okuma ve işleme
* Veriyi dizi, matris ve dictionary yapılarıyla organize etme
* Gerçekçi mesafe verilerini graf olarak temsil etme
* Dijkstra algoritmasını uygulama
* Matris tabanlı giriş verileriyle çalışma
* Binary pattern verilerinden feature vector oluşturma
* Harici ML kütüphanesi kullanmadan temel sınıflandırıcı implementasyonu
* Nesne yönelimli programlama prensipleriyle kod organize etme
