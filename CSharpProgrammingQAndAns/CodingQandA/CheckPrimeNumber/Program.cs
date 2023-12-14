namespace CheckPrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number :");
            int number=Convert.ToInt32(Console.ReadLine());
            PrimeNumber primeNumber = new PrimeNumber();
            primeNumber.prim(number);


        }
    }
}