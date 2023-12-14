namespace FizzBuzz
{
    public class FizzBuzz
    {
        public void printValues()
        {
            for(int i=1;i<=100;i++)
            {
                if(i%15==0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                if(i%3==0)
                {
                    Console.WriteLine("Fizz");
                }
                if(i%5==0) 
                {
                    Console.WriteLine("Buzz");
                }
               
                Console.WriteLine(i);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            fizzBuzz.printValues();
        }
    }
}