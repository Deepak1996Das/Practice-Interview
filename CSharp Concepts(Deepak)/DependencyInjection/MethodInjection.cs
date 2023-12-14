using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public interface IIset
    {
        void Print();
    }
    public class Servic : IIset
    {
        public void Print()
        {
            Console.WriteLine("print........");
        }
    }
    public class Client
    {
        private IIset _set;
        public void Run(IIset serv)
        {
            this._set = serv;
            Console.WriteLine("start");
            this._set.Print();
        }
    }
   
}
