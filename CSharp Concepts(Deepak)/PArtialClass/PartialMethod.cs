using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class A
    {
        public partial void OnSomethingHappened(string s);
    }
    // This part can be in a separate file.   
    public partial class A
    {
        // Comment out this method and the program   
        // will still compile.   
        public partial void OnSomethingHappened(String s)
        {
            Console.WriteLine("Something happened: {0}", s);
        }
    }
}
