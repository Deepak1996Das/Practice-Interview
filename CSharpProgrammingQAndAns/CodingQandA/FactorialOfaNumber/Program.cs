namespace FactorialOfaNumber
{
    internal class Program
    {
        
        public int recoursion(int n)
        {
            if(n==0)
            {
                return 1;
            }
            else
            {
                return n* recoursion(n-1);
            }

        }
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter your number :");
            int num =Convert.ToInt32( Console.ReadLine());

            //-------------------------------------
            /*
            int fact = 1;

            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine(fact);
            */

            //-------------------------------------
            Program program=new Program();
           int fact=program.recoursion(num);
            Console.WriteLine(fact);

        } 
    }
}