namespace VirtualMethod
{
    public class Anumal
    { 
        public virtual void Sound()
        {

        }
    }

    public class Lion:Anumal
    {
        public override void Sound()
        {
            Console.WriteLine("LION  HMMM");   
        }
    }

    public class Tiger : Anumal
    {
        public override void Sound()
        {
            Console.WriteLine("TIger  haaaa");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion();
            lion.Sound();

            Tiger tiger = new Tiger();
            tiger.Sound();
        }
            
    }
}