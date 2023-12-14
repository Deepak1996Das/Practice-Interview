using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public class ImplementInterface : IInterfaceA, IInterfaceB
    {
        void IInterfaceA.Test()
        {
            Console.WriteLine("IInterfaceA");
        }

        void IInterfaceB.Test()
        {
            Console.WriteLine("IInterfaceB");
        }

        public void SupperTest()
        {
            Console.WriteLine("I am ImplementInterface class");
        }
    }
}
