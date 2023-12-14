namespace FibonacciSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number:");
            int num=Convert.ToInt32(Console.ReadLine());

           
            int i=0,j=1,nextnumber;

            Console.Write(i+","+j);

            for(int k=2;k<=num;k++)
            {
                nextnumber = i + j;
                Console.Write(","+nextnumber);
                i=j; j=nextnumber;
            }





        }
    }
}