using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class StaticConstructorClass
    {
        static StaticConstructorClass() 
        {
            Console.WriteLine("I am static constructor");
        }

       public static void StaticMethod()
        {
            Console.WriteLine("I am static Method");
        }

        public void NormalMethod()
        {
            Console.WriteLine("I am normal method");
        }
    }
}
