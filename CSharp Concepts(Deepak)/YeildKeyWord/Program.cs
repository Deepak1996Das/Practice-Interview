using YeildKeyWord;

public class Program
{
    private static void Main(string[] args)
    {
       YeildClass yeildClass = new YeildClass();
       var Evens= yeildClass.EvenNumber(10);
        foreach (int i in Evens)
        {
            Console.WriteLine(i);
        }
    }
}