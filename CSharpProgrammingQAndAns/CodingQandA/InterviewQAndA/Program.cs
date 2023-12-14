using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace InterviewQAndA
{
    public class Program
    {
        static void Main(string[] args)
        {
           List<int> numbers=new List<int>() {1,2,3,4,5,6,8,7,9,10,14,144,144 };
            var number = Console.ReadLine();
            
            try
            {
               int convertNumber = Convert.ToInt32(number);

            }
            catch
            {
                Console.WriteLine("This is not a number");
                number = Console.ReadLine();
            }
           
            
            
        }
            
    }
}