namespace FindMaximumNumberFromArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3 ,4,82,83,73829,388,272,7737,93};

            //-----------------------------------
            /*
            int maxNumber=0;
            for(int i=0;i<ints.Length;i++)
            {
                if (ints[i] > maxNumber)
                {
                    maxNumber = ints[i];
                }
                
            }

            Console.WriteLine(maxNumber);
            */
            //----------------------------------------

            int maxNumber= ints.Max();
            Console.WriteLine(maxNumber);

            //------------------------------------------ 
            /*
            int[] ints = { 1, 2, 3, 5, 6, 7, 8, 9, 10, 20 };

            List<int> list = new List<int>();

            List<int> newiteam = ints.ToList();
            newiteam.Sort();

            for (int i = 1; i <= newiteam[newiteam.Count - 1]; i++)
            {
                int item = newiteam.FirstOrDefault(u => u == i);
                if (item == 0)
                {
                    Console.WriteLine(i);
                }
            }
            */
        }
    }
}