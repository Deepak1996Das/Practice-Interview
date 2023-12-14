namespace DependencyInjection
{
    internal class Program
    {
        static void Main()
        {
            /* 
                //This constructor dependency injection
            ConstructorInjection constructorInjection=new ConstructorInjection(new ImplimentedClass());
            constructorInjection.Test();
            */



            /*
            EventLogWriter elw = new EventLogWriter();
            PropertyInjection at = new PropertyInjection();
            at.notify(elw, "to logg");
            Console.ReadKey();
            */



            Client client=new Client();
            client.Run(new Servic());

        }
    }
}