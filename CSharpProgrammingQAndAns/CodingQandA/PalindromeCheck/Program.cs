using System.Runtime.CompilerServices;
using System.Transactions;

namespace PalindromeCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //-------------------------------------------------------
            /*
            Console.Write("Enter Your string :");
            string str=Console.ReadLine();

            char[] revese = str.ToCharArray();

            Array.Reverse(revese);

            string newReve = new string(revese);
            Console.WriteLine(newReve);
            if (str.ToLower() ==newReve.ToLower()) 
            {
                Console.WriteLine($"{str} is a Palindrome string");
            }
            else
            {
                Console.WriteLine($"{str} is not a Palindrome string");

            }
            */

            //-------------------------------------------------------
            

            int num = 123;
            string numbers=Convert.ToString(num);

            char[] chars = numbers.ToCharArray();

            Array.Reverse(chars);

            int rever = Convert.ToInt32(new string(chars));

            if(num==rever)
            {
                Console.WriteLine($"{num} is a Palindrome number");
            }
            else
            {
                Console.WriteLine($"{num} is not a Palindrome number");
            }

            

           

        }
    }
}