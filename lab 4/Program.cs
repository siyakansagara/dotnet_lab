using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculator c1 = new Calculator();
            //Console.Write("Enter a number:");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter a number:");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter a number:");
            //int c = Convert.ToInt32(Console.ReadLine());
            //double d = Convert.ToDouble(Console.ReadLine());
            //double e = Convert.ToDouble(Console.ReadLine());
            //Console.Write(c1.Add(a, b));
            //Console.Write(c1.Add(a ,b, c));
            //Console.Write(c1.Add(d, e));
            //c1 = new Calculator();

            //p2

            //Employee employee = new Employee();
            //employee.getInfo("ABC");
            //employee.getInfo("ABC", 21);
            //employee.getInfo("ABC", 21 , 15000);
            //employee.display();

            //p3
            //person person = new person();
            //Console.WriteLine("public number:"+ person.a);
            //Console.WriteLine("private number:" + person.b);
            //Console.WriteLine("protected number:" + person.c);
            //Console.WriteLine("interbal number:"+ person.d);

            //p4
            //Animal animal = new Animal();
            //Animal dog = new Dog();
            //Animal cat = new Cat();
            //dog.Sound();

            //p5
            Shape Circle = new Circle(12.5);
            Shape Rec = new Rectangle(10.5, 10.5);
            Shape tri = new Triangle(14.5, 11.5);

            Console.WriteLine("Area of  circle:" + Circle.CalculateArea());
            Console.WriteLine("Area of  Rectangle:" + Rec.CalculateArea());
            Console.WriteLine("Area of  Triangle:" + tri.CalculateArea());
        }
    }
}
