using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPrimeNumber
{
    public class PrimeNumber
    {
        public void prim(int number)
        {
            bool k=false;

            if(number==0 || number==1) 
            {
                Console.WriteLine($"{number } is not a prime number.");
            }
            else
            {
                for(int i=2; i<number;i++)
                {
                    if(number%i==0) 
                    {
                        k= true;
                    }
                }
            }

            if(k)
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
            else
            {
                Console.WriteLine($"{number } is a prime number");
            }
          
           
        }
    }
}
