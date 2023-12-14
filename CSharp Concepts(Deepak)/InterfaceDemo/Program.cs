namespace InterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParentClass parentClass = new ParentClass();
            parentClass.ParentclassMethod();



            IInterfaceA parentClassA = new ParentClass();
            parentClassA.Test();

            IInterfaceB parentClassB = new ParentClass();
            parentClassB.Test();

            ImplementInterface implementInterface= new ParentClass();
            implementInterface.SupperTest();



        }
    }
}