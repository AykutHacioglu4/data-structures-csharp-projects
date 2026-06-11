# Data Structures Projects in C#

## English

This repository includes two C# projects developed as part of a Data Structures course. The projects demonstrate practical implementations of data structures, graph algorithms, matrix-based data processing, file handling, and a basic custom neural-network-style classifier.

The main purpose of this repository is to show how fundamental computer science concepts can be applied to real problems using C# and object-oriented programming principles.

---

## Projects Included

### 1. Road Distance and Shortest Path Analysis

This project analyzes road distance data between Turkish cities and İzmir districts. It uses matrix-based data structures and file processing techniques to read distance data from external files, represent locations as graph nodes, and calculate shortest paths between non-neighboring locations.

The project applies Dijkstra's shortest path algorithm to compare predefined road distances with calculated shortest-path values. The results are written to output files for analysis.

#### Main Features

* Reads city and district distance data from external files
* Stores distance information using arrays and matrices
* Represents neighborhood relationships with dictionary-based structures
* Applies Dijkstra's algorithm for shortest path calculation
* Compares predefined distances with calculated shortest-path results
* Generates output files for result analysis

#### Concepts Used

* Arrays
* Matrices
* Dictionaries
* File I/O
* Graph representation
* Dijkstra's shortest path algorithm

---

### 2. Custom Neural Network for Binary Pattern Recognition

This project implements a simple neural-network-style classifier in C# without using external machine learning libraries. The application classifies 5x5 binary matrix patterns into predefined categories.

The dataset is generated programmatically by creating different variations of binary patterns. These matrix inputs are converted into feature vectors and processed by a custom classifier. The model is trained through iterative weight updates and evaluated using both training samples and unseen test samples.

The goal of this project is to demonstrate the core logic behind data preprocessing, feature representation, training, classification, and evaluation.

#### Main Features

* Generates synthetic 5x5 binary pattern data
* Represents image-like data using two-dimensional arrays
* Converts matrix inputs into one-dimensional feature vectors
* Implements a basic classifier from scratch
* Performs iterative training with weight updates
* Evaluates model performance on sample inputs

#### Concepts Used

* Object-oriented programming
* Matrix processing
* Feature extraction
* Basic classification logic
* Custom neural network implementation
* Training and testing workflow

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

## Purpose of the Repository

This repository was created to demonstrate practical software development skills through academic projects. The implementations focus on understanding and applying core computer science topics instead of relying heavily on external libraries.

The projects show experience in:

* Writing structured C# code
* Working with data files
* Designing algorithm-based solutions
* Applying graph algorithms to real-world-like data
* Implementing basic machine learning logic manually
* Organizing code using object-oriented principles

---

# Veri Yapıları Projeleri - C#

## Türkçe

Bu repository, Veri Yapıları dersi kapsamında geliştirilmiş iki ayrı C# projesini içermektedir. Projelerde veri yapıları, graf algoritmaları, matris tabanlı veri işleme, dosya okuma/yazma işlemleri ve temel seviyede özel olarak yazılmış bir sinir ağı / sınıflandırıcı yapısı uygulanmıştır.

Bu repository’nin temel amacı, bilgisayar biliminin temel konularının C# ve nesne yönelimli programlama prensipleri kullanılarak gerçek problemlere nasıl uygulanabileceğini göstermektir.

---

## Projeler

### 1. Karayolları Uzaklık ve En Kısa Yol Analizi

Bu proje, Türkiye’deki şehirler ve İzmir ilçeleri arasındaki karayolu mesafelerini analiz eder. Projede mesafe verileri harici dosyalardan okunur, matris tabanlı veri yapıları üzerinde saklanır ve şehirler/ilçeler graf düğümleri olarak temsil edilir.

Proje kapsamında, komşu olmayan şehir veya ilçe çiftleri arasındaki en kısa yollar Dijkstra algoritması ile hesaplanır. Hesaplanan değerler, dosyalarda bulunan mevcut mesafe değerleriyle karşılaştırılır ve sonuçlar analiz edilebilmesi için çıktı dosyalarına yazdırılır.

#### Temel Özellikler

* Şehir ve ilçe mesafe verilerini harici dosyalardan okuma
* Mesafe bilgilerini dizi ve matris yapılarıyla saklama
* Komşuluk ilişkilerini dictionary tabanlı yapılarla temsil etme
* Dijkstra algoritması ile en kısa yol hesaplama
* Tanımlı mesafe ile hesaplanan mesafeyi karşılaştırma
* Sonuçları çıktı dosyalarına yazdırma

#### Kullanılan Kavramlar

* Diziler
* Matrisler
* Dictionary veri yapısı
* Dosya okuma/yazma işlemleri
* Graf temsili
* Dijkstra en kısa yol algoritması

---

### 2. Binary Pattern Recognition için Basit Sinir Ağı

Bu proje, herhangi bir harici makine öğrenmesi kütüphanesi kullanılmadan C# ile geliştirilmiş temel bir sinir ağı / sınıflandırıcı mantığını içerir. Uygulama, 5x5 boyutundaki binary matrisleri önceden tanımlanmış sınıflara ayırır.

Veri seti program içinde farklı binary pattern varyasyonları oluşturularak üretilir. Bu matris verileri tek boyutlu feature vector yapısına dönüştürülür ve özel olarak yazılmış sınıflandırıcı tarafından işlenir. Model, iteratif ağırlık güncellemeleri ile eğitilir ve hem eğitim örnekleri hem de daha önce görmediği test örnekleri üzerinde değerlendirilir.

Bu projenin amacı, veri ön işleme, feature representation, eğitim, sınıflandırma ve değerlendirme adımlarının temel çalışma mantığını göstermektir.

#### Temel Özellikler

* 5x5 binary pattern verileri üretme
* Görsel benzeri verileri iki boyutlu dizilerle temsil etme
* Matris girişlerini tek boyutlu feature vector yapısına dönüştürme
* Sıfırdan yazılmış basit sınıflandırıcı yapısı
* Ağırlık güncellemeleriyle iteratif eğitim yapma
* Model performansını örnek girdiler üzerinde değerlendirme

#### Kullanılan Kavramlar

* Nesne yönelimli programlama
* Matris işleme
* Feature extraction
* Temel sınıflandırma mantığı
* Özel sinir ağı implementasyonu
* Eğitim ve test süreci

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

## Repository Amacı

Bu repository, akademik projeler üzerinden pratik yazılım geliştirme becerilerini göstermek amacıyla hazırlanmıştır. Projelerde harici kütüphanelere bağımlı kalmak yerine temel bilgisayar bilimi konularının mantığını anlamaya ve manuel olarak uygulamaya odaklanılmıştır.

Projeler aşağıdaki becerileri göstermektedir:

* Yapılandırılmış C# kodu yazma
* Harici veri dosyalarıyla çalışma
* Algoritma tabanlı çözüm tasarlama
* Graf algoritmalarını gerçek veri benzeri yapılara uygulama
* Temel makine öğrenmesi mantığını manuel olarak implemente etme
* Nesne yönelimli programlama prensipleriyle kod organize etme
