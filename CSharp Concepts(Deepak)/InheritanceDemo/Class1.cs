﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Class1
    {
        private void Sum(int a,int b)
        { 
            Console.WriteLine(a + b);
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        internal void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        protected void Div(int a, int b) 
        {
            Console.WriteLine(a / b);
        }
        public static void Calculation()
        {
            Console.WriteLine("This is a console ca;culation application");
        }
    }
}
