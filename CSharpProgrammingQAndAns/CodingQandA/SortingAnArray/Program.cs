namespace SortingAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 2, 28, 2522, 2, 4353, 53, 636 };
           var shortedints= ints.OrderBy(i => i);

            foreach(int i in shortedints) 
            { 
                Console.Write(i+" ");
            }
        }
    }
}