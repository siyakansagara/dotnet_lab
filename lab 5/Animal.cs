using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    internal class Animal
    {
            public void Eat()
            {
                Console.WriteLine("Main class");
            }
        
    }
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog class");
        }
    }
}
