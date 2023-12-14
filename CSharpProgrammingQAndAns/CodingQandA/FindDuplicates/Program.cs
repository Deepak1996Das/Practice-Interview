using System.ComponentModel;
using System.Xml.Linq;
using System;
namespace FindDuplicates
{
    internal class Program
    {
        /*
        Write a function to find and return any duplicate elements from a given 
        array of integers.  
        */
        static void Main(string[] args)
        {
            //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 5, 4, 9 };
            //for (int i = 0; i < ints.Length; i++)
            //{ 
            //    {
            //        if (ints[j] == ints[i])
            //        {
            //            Console.WriteLine(ints[j]);
            //        }
            //    }
            //}
            /*-------------------------------------------------------

            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 5, 4, 9, 9 };

            List<int> list = new List<int>();

            for (int i = 0; i < ints.Length; i++)
            {
                for (int j = i + 1; j < ints.Length; j++)
                {
                    if (ints[i] == ints[j])
                    {
                        list.Add(ints[i]);
                    }
                }
            }

            List<int> distinct = list.Distinct().ToList();

            foreach (var i in distinct)
            {
                Console.Write(i + " ");
            }

            ------------------------------------------------*/ 

        }
    }
}