using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Delegate
{
    delegate void MyDelegate(string Name);
    public  class DelegateMethod
    {
      
        public static void NameMethod(string Name)
        {
            Console.WriteLine(Name);
        }
       
       
        

    }

    public class InVokingClass
    {

        public static void Mysystem()
        {
            MyDelegate del = new MyDelegate(DelegateMethod.NameMethod);
            del.Invoke("Deepak");
        }
    }
}
