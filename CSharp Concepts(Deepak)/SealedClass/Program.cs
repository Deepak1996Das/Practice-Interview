using System.Diagnostics;
using System.Xml.Linq;

namespace SealedClass
{
    public  class Product
    {
        public string Name { get;}
        public decimal Price { get;}

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
    public sealed class PhysicalProduct :Product
    {
        public int Weight { get; }

        public PhysicalProduct(string name, decimal price, int weight) :base(name,price)
        {
            Weight = weight;
        }
    }
    public sealed class DigitalProduct: Product
    { 
        public string DownloadLink { get; }

        public DigitalProduct(string name, decimal price, string downloadLink) : base(name, price)
        {
            DownloadLink = downloadLink;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            PhysicalProduct physicalProduct = new PhysicalProduct("T-Shirt", 19.99m, 300);
            DigitalProduct digitalProduct = new DigitalProduct("E-book", 9.99m, "http://example.com/ebook");

            Console.WriteLine($"Physical Product: {physicalProduct.Name}, Weight: {physicalProduct.Weight}g, Price: ${physicalProduct.Price}");
            Console.WriteLine($"Digital Product: {digitalProduct.Name}, Download Link: {digitalProduct.DownloadLink}, Price: ${digitalProduct.Price}");

        }
    }
}