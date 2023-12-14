using Constructor;

internal class Program
{
    private static void Main(string[] args)
    {
        //Class Name:-> ConstructorClass
        StaticConstructorClass.StaticMethod();
        StaticConstructorClass constructorClass = new StaticConstructorClass();
        constructorClass.NormalMethod();


        // Class Name:->  CopyContructorClass

        CopyContructorClass copyContructorClass =new CopyContructorClass("Deepak");

        CopyContructorClass copyContructorClassCopy=new CopyContructorClass(copyContructorClass);

    }
}