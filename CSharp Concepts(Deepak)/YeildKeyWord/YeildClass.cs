using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeildKeyWord
{
    public class YeildClass
    {
        public IEnumerable<int> EvenNumber(int iput)
        {
            for(int i=0; i< iput; i=i+2)
            { 
                yield return i;
            }
        }
    }
}
