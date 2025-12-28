using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class Animal
    {
        public  virtual void Sound()
        {
            Console.WriteLine("Animal sound");
        }
    }
    class Dog: Animal
    {
        public override void Sound()
        {
            Console.WriteLine("dog bark....");
        }
    }
    class Cat: Animal
    {
        public  override void Sound()
        {
            Console.WriteLine("cat....");
        }
    }
}
