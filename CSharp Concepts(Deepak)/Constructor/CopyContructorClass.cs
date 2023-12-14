using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{

    public class CopyContructorClass
    {
        private string name;
        public CopyContructorClass(string name)
        {
            this.name = name;
        }

        public CopyContructorClass(CopyContructorClass copy)
        {
            Console.WriteLine( copy.name);
        }

    }

   
}
