using System;

namespace EcommerceSearchPlatform
{
    // 1. Abstract Base Class for all products
    public abstract class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }

        public abstract void DisplayProductInfo();
    }

    // 2. Concrete Product: Electronics
    public class ElectronicProduct : Product
    {
        public ElectronicProduct(string id, string name)
        {
            ProductId = id;
            ProductName = name;
            Category = "Electronics";
        }

        public override void DisplayProductInfo()
        {
            Console.WriteLine($"[Electronics] ID: {ProductId} | Name: {ProductName}");
        }
    }

    // 3. Concrete Product: Clothing
    public class ClothingProduct : Product
    {
        public ClothingProduct(string id, string name)
        {
            ProductId = id;
            ProductName = name;
            Category = "Clothing";
        }

        public override void DisplayProductInfo()
        {
            Console.WriteLine($"[Clothing] ID: {ProductId} | Name: {ProductName}");
        }
    }

    // 4. THE FACTORY: Handles the creation logic
    public abstract class ProductCreator
    {
        public abstract Product FactoryMethod(string id, string name);
    }

    public class ElectronicsCreator : ProductCreator
    {
        public override Product FactoryMethod(string id, string name)
        {
            return new ElectronicProduct(id, name);
        }
    }

    public class ClothingCreator : ProductCreator
    {
        public override Product FactoryMethod(string id, string name)
        {
            return new ClothingProduct(id, name);
        }
    }
}