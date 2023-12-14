using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMissingNumber
{
    public class MissingNumber
    {
       
        public void findNumber(int[] ints)
        {
            List<int> miss = new List<int>();
            int maxnumber=ints.Max(x => x);

            bool status = false;

            for(int i=0;i<=maxnumber;i++) 
            {
                foreach(int x in ints) 
                {
                    if(i==x) 
                    {
                        status = true;
                    }
                }

                if(status == false)
                {
                    miss.Add(i);
                }
                status = false;
            }

            foreach(int x in miss)
            {
                Console.WriteLine(x);
            }
        }
    }
}
