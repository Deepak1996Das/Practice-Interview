using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAndMethod
{
    public  class AbstractClass2:AbstractClass1
    {
        public override void  Sub(int a, int b)
        {
            Console.WriteLine(a-b);
        }

        public new  void mul(int a, int b)
        {
            Console.WriteLine(a*b);
        }
        public void mulmax(int a, int b)
        {
            Console.WriteLine(a*b*b );
        }
    }
}
