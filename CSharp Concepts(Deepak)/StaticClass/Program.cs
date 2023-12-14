namespace StaticClass
{
    static class Product
    {
      public static string Name = "Deepak";
       public static decimal Price;
        static Product()
        {
            Price = 100;
        }

        public static double PriceRate()
        {
            return Convert.ToDouble((Price * 50 / 100) + Price);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Product.Name}  , price {Product.Price}");
            double FinalPrice = Product.PriceRate();
            Console.WriteLine(FinalPrice);
        }
    }
}