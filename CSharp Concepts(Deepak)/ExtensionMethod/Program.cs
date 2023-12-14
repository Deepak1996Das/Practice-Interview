using ExtensionMathClass;

namespace ExtensionMethod
{
    public static class ExtraMathMehod
    { 
        public static void Multi(this MathMethods mathMethods,int a,int b)
        {
            Console.WriteLine(a * b);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            MathMethods mathMethods = new MathMethods();
            mathMethods.Multi(5, 10);
            mathMethods.Sub(10, 5);
        }
    }
}