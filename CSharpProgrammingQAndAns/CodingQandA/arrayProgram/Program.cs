internal class Program
{
    private static void Main(string[] args)
    {
        List<int> ints = new List<int>() { 1,2,34,2,4,2,3,4,4,22,4,5,223,10,4,7,8,4,6,73,6,8,54,87,8,2,9,45,7,8};

        List<int> output = ArryIndex(ints, 2);
        foreach (int i in output) 
        {
            Console.WriteLine(i);
        }
    }



    // Method to Find first index and Last Index from a array
    public static List<int> ArryIndex(List<int> ints,int num) 
    {
       
        int firstIndex = -1;
        int lastIndex = -1;

        for (int i = 0; i < ints.Count; i++)
        {
            if (ints[i] == num)
            {
                if (firstIndex < 0)
                {
                    firstIndex = i;
                    continue;
                }
                else
                {
                    lastIndex = i;
                    continue;
                }
            }
        }

        return (new List<int>() { firstIndex, lastIndex });
    }
}