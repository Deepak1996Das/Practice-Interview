using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public interface ICustomer
    {
        void CustomerNameMethod();
    }

    public class ImplimentedClass : ICustomer
    {
        public void CustomerNameMethod()
        {
            Console.WriteLine("My name is Customer1");
        }
    }


    public class ConstructorInjection
    {
        public readonly ICustomer _text;
        public ConstructorInjection(ICustomer text)
        {
            _text=text;
        }

        public void Test() 
        {
            _text.CustomerNameMethod();
        }
    }
}
