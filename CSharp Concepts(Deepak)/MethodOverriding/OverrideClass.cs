using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    public class MethodHiding
    {
        public void Print()
        {
            MethodHidingA obj1 = new MethodHidingA();
            obj1.Print();
            MethodHidingB obj2 = new MethodHidingB();
            obj2.Print();

            //MethodHidingB obj3 = new MethodHidingA();
            //obj3.Print();
            MethodHidingA obj4 = new MethodHidingB();
            obj4.Print();
        }
    }
    public class MethodHidingA
    {
        public MethodHidingA()
        {
        }
        public virtual void Print()
        {
            Console.WriteLine("printA");
        }
    }
    public class MethodHidingB : MethodHidingA
    {
        public MethodHidingB()
        {

        }
        public override void Print()
        {
            Console.WriteLine("printB");
        }
    }
}
