using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class student
    {
        public string name;
        public int rollno;
        public int marks;

        public void display()
        {
            Console.WriteLine("student name:" + name);
            Console.WriteLine("student rollno:" + rollno);
            Console.WriteLine("student marks:" + marks);
            Console.WriteLine();
        }
    }
    
}
