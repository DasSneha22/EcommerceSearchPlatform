using System;

namespace EcommerceSearchPlatform
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductCreator electronicsFactory = new ElectronicsCreator();
            ProductCreator clothingFactory = new ClothingCreator();

            // REQUIREMENT MET: An unsorted array specifically for Linear Search
            Product[] unsortedCatalog = new Product[]
            {
                electronicsFactory.FactoryMethod("E02", "Laptop"),
                clothingFactory.FactoryMethod("C03", "Cotton T-Shirt"),
                electronicsFactory.FactoryMethod("E01", "Smartphone"),
                clothingFactory.FactoryMethod("C01", "Winter Jacket"),
                electronicsFactory.FactoryMethod("E03", "Bluetooth Speaker"),
                clothingFactory.FactoryMethod("C02", "Denim Jeans")
            };

            // REQUIREMENT MET: A strictly sorted array specifically for Binary Search
            Product[] sortedCatalog = new Product[]
            {
                clothingFactory.FactoryMethod("C01", "Winter Jacket"),
                clothingFactory.FactoryMethod("C02", "Denim Jeans"),
                clothingFactory.FactoryMethod("C03", "Cotton T-Shirt"),
                electronicsFactory.FactoryMethod("E01", "Smartphone"),
                electronicsFactory.FactoryMethod("E02", "Laptop"),
                electronicsFactory.FactoryMethod("E03", "Bluetooth Speaker")
            };

            Console.WriteLine("--- E-Commerce Search Platform ---");
            string targetSearch = "C02";
            Console.WriteLine($"\nSearching for Product ID: {targetSearch}\n");

            // Execute Linear Search on the UNSORTED array
            Console.WriteLine("Executing Linear Search on unsorted array...");
            Product foundLinear = SearchEngine.LinearSearch(unsortedCatalog, targetSearch);

            Console.WriteLine("\n-----------------------------------\n");

            // Execute Binary Search on the SORTED array
            Console.WriteLine("Executing Binary Search on sorted array...");
            Product foundBinary = SearchEngine.BinarySearch(sortedCatalog, targetSearch);

            if (foundBinary != null)
            {
                Console.WriteLine("\nProduct Details:");
                foundBinary.DisplayProductInfo();
            }
             Console.ReadLine();
        }
    }
}