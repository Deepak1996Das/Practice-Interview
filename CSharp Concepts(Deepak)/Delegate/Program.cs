using Delegate;
namespace DeligateStyle
{
    delegate void My(int a, int b);
    public class Program
    {
        public static void Add(int a,int b) 
        {
            Console.WriteLine(a + ", " + b);
        }
        private static void Main(string[] args)
        {
            My my=new My(Add);
            my(10, 20);

            InVokingClass.Mysystem();

        }
    }
}