using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class division
    {
        public int a;
        public int b;

        public division(int a,int b)
        {
            this.a = a;
            this.b = b;
        }
        public void div(int a , int b)
        {
            try
            {
                int ans = a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error message: can not divide by zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter integer value");
            }
            finally
            {
                Console.WriteLine("Exception done");
            }
        }
    }
}
