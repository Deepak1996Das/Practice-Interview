using Methods;
using System.Reflection.Emit;
namespace MethodExample
{

    public class Program
    {
        /*
        Level of Implementation/Access modifiers types |	At Namespace level	| At class Level At function level
             Public                                         yes                         yes
             Private                                        No                          yes
             Protected                                      No                          yes
             Internal                                       yes                         yes
             Protected Internal                             No                          yes
        */
        private static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            
        }
    }
}