namespace BinarySearch
{
    /*
      Binary Search: Write a C# function to perform a binary search on a sorted array and 
      return the index of the target element (if found) or -1 (if not found).
     */
    internal class Program
    {
        static void Main(string[] args)
        {

            //int[] ints = { 1, 2, 3 ,4,5,6,7,8,9,10};
            //int num = 5;
            //BinorySearchNumber binorySearchNumber = new BinorySearchNumber();
            //binorySearchNumber.binorySearchNumber(ints, num);


             int num = Convert.ToInt32(Console.ReadLine());
            int[] ints = { 1, 2, 3, 4, 5, 5, 6, 7, 8, 50, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Array.Sort(ints);
            int find = ints.FirstOrDefault(i => i == num);
            if (find == 0)
            {
                Console.WriteLine("No number in the array");
            }
            else
            {
                Console.WriteLine(Array.IndexOf(ints, find));
            }

        }
    }
}