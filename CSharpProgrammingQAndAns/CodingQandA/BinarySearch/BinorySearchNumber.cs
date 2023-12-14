using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class BinorySearchNumber
    {
        public void binorySearchNumber(int[] ints,int num) 
        { 
            int len=ints.Length;
            if(len == 0)
            {
                Console.WriteLine("No number in array.");
            }
            int mid = ints[len / 2];
            if(num==mid)
            {
                Console.WriteLine((len/2));
            }
            if(num<mid)
            {
                int i = 0;
                while(i<mid)
                {
                    if (ints[i] == num) 
                    {
                        Console.WriteLine(i);
                    }
                    
                    i++;
                }
            }
            if(num>mid)
            {
                int i =len/2;

                while(i<ints.Length)
                {
                    if (ints[i] == num)
                    {
                        Console.WriteLine(i);
                    }
                    i++;
                }
                Console.WriteLine("-1");
            }
        }
    }
}
