using AbstractClassAndMethod;

public class Program
{
    private static void Main(string[] args)
    {
        AbstractClass1 class1 = new AbstractClass2();
        class1.Sub(19, 5);
        class1.mul(20, 5);
        class1.mulmax(20, 5);


        AbstractClass2 class2 = new AbstractClass2();
        class2.Sub(19, 5);
        class2.mul(20, 5);
        class2.mulmax(20, 5);
    }
}