using System;
using System.Collections.Generic;

namespace CountOccurenceOfChar
{
    internal class Program
    {
        public static void CountOccurenceOfChar(string name)
        {
            Dictionary<Char, int> dic = new Dictionary<Char, int>();
            foreach (char c in name) 
            {
                dic.TryGetValue(c, out int value);
                dic[c] = value+1;
            }

            foreach (var x in dic)
            {
                Console.WriteLine($"{x.Key} : {x.Value}");
            }
        }
        static void Main(string[] args)
        {
            CountOccurenceOfChar("Deepak");
        }
    }
}
