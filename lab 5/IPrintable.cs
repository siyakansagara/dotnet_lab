using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    internal interface IPrintable
    {
        void Printdetail();
    }
    class Book : IPrintable
    {
        public void Printdetail()
        {
            Console.WriteLine("Book detail");
        }
    }
    class Magazine : IPrintable
    {
        public void Printdetail()
        {
            Console.WriteLine("Magazine detail");
        }
    }
}
