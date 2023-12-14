using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAverage
{
    public class Average
    {
        public void averageMethod(List<double> numbers) 
        { 
            double len=numbers.Count();
            int sum=0;
            foreach(int i in numbers) 
            { 
                sum += i;
            }
            double avg=sum/len;

            Console.WriteLine(avg);

        }
    }
}
