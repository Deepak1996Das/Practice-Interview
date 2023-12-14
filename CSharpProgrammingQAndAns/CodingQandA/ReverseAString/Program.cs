namespace ReverseAString
{
    internal class Program
    {
        public void method()
        {
            Console.Write("Enter your string char:");
            string? str = Console.ReadLine();

            if (str == null || str == "")
            {
                Console.WriteLine("You do not enter any string");
                method();
            }
            else
            {
                string copy = str;
                char[] chars = str.ToCharArray();
                Array.Reverse(chars);

                if (copy.ToLower() == (new string(chars)).ToLower())
                {
                    Console.WriteLine("This is a polindrom string");
                    method();
                }
                else
                {
                    Console.WriteLine("This is not a polindrom string");
                    method();
                }

            }
            static void Main(string[] args)
            {


                Console.Write("Enter your string :");
                string str = Console.ReadLine();
                //--------------------------------------------
                /*
                char[] strchar = str.ToCharArray();

                Array.Reverse(strchar);

                 // string reverseString=new string(strchar);
                Console.WriteLine(new string(strchar));
                */
                //---------------------------------------------
                char[] c = new char[str.Length];
                for (int i = str.Length - 1, j = 0; i >= 0; i--, j++)
                {
                    c[j] = str[i];
                }

                Console.Write(new string(c));

                //------------------------------------------------

                //reverse a number



            }
        }
    }
}