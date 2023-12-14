using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAndMethod
{
    public abstract class AbstractClass1
    {
        public void Sum(int a,int b)
        {
            Console.WriteLine(a + b);
        }

        public abstract void Sub(int a, int b);

        public virtual void mul(int a, int b)
        {
            Console.WriteLine(a);
        }

        public  void mulmax(int a, int b)
        {
            Console.WriteLine(a);
        }

    }
}
