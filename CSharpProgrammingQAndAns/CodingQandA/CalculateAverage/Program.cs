namespace CalculateAverage
{
    /*
       Calculate Average: Write a C# function to calculate the average of a list of numbers.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers= new List<double>() { 1, 2, 3, 4, 5, 6 };
            Average average= new Average();
            average.averageMethod(numbers);
        }
    }
}