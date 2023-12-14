public struct StructCare
{
   public string Name;
   public int price;
}

public class ClassCare
{
    public string Name;
    public int price;
}


public class Program
{
    public static void ChangeMethodStruct(StructCare structCare)
    {
        structCare.price = 0;
    }

    public static void ChangeMethodClass(ClassCare classCare)
    {
        classCare.price = 0;
    }




    private static void Main(string[] args)
    {
         



        StructCare structCare = new StructCare();
        structCare.Name = "Nano";
        structCare.price = 100;

        ClassCare classCare = new ClassCare();
        classCare.Name = "Hunda";
        classCare.price = 200;

        Console.WriteLine("This is structure"+" " +"Name:-"+ structCare.Name+" " +"Price:-"+ structCare.price);
        Console.WriteLine("This is Class" + " " + "Name:-" + classCare.Name + " " + "Price:-" + classCare.price);

        Program.ChangeMethodStruct(structCare);
        Console.WriteLine("This is structure" + " " + "Name:-" + structCare.Name + " " + "Price:-" + structCare.price);

        ChangeMethodClass(classCare);
        Console.WriteLine("This is Class" + " " + "Name:-" + classCare.Name + " " + "Price:-" + classCare.price);

    }
}