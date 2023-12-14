namespace CountWordsInAString
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your sentence :");
            string str=Console.ReadLine();
            CountWords countWords = new CountWords();
            countWords.counts(str);
        }
    }
}