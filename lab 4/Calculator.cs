using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a , int b , int c)
        {
            return Add(a , b , c);
        }
        public double Add(double a , double b)
        {
            return a + b;
        }
    }
}
