using Microsoft.VisualBasic;

namespace RemoveAStringFromASentence
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string Sentence ="My name is Deepak kumar Das";

            string[] strings = Sentence.Split(' ');

            for(int i=0;i<strings.Length;i++)
            {
                if (strings[i]!="is")
                {
                    Console.Write(strings[i]+" ");
                }
               
            }
         }
    }
}