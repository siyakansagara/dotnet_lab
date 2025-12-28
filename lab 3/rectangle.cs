using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class rectangle
    {
        public int len;
        public int bre;

       public  rectangle(int len, int bre)
        {
            this.len = len;
            this.bre = bre;
        }
        public int area()
        {
            return len * bre;

        }
        public void display()
        {
            Console.WriteLine("Area of rectangle" + area());
        }
    }
}
