
using InheritanceDemo;
namespace InheritanceDemo1
{
    /*
     * Inheritance is process to create parent child relationship.
     * Inheritance allow us to code reusable 
     * There are 4 types of inheritance:- Single inheritance, Multiple inhetitance,Multilevel inheritance,Higherchial inheritance
     * C# does not support multiple inheritance
     * We can achive multiple inheritance by interface
     * Base class or abstract class must come before interface in case inheritance
     * We can not inherit a class from two base class or interface 
     * 
     * 
     * 

     * 
     */
    public class ParentClass : Interface1, Interface2
    { 

    }

    internal class Program
    {
        
        static void Main(string[] args)
        {
            Class2 class2 = new Class2();
            class2.Sub(5, 5);
            class2.Mul(5, 5);
            Class1.Calculation();
        }
    }
}