namespace FindMissingNumber
{
    /*
      Find Missing Number: Write a C# function to find the missing number in an array of integers from 1 to N,
      where N is the length of the array, and one number is missing.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1,3, 4, 6, 7, 8,9,39,394,3939,8};
            MissingNumber missingNumber = new MissingNumber();
            missingNumber.findNumber(ints);


        }
    }
}