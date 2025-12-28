using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class Shape
    {
        public  virtual double CalculateArea()
        {
            Console.WriteLine("Calculate Area...");
            return 0;
        }
    }
    class Circle: Shape
    {
        double r;
        public Circle(double r)
        {
            this.r = r;
        }
        public override double CalculateArea()
        {
            return 3.14 * r * r;
        }
    }
    class Rectangle: Shape
    {
        double length;
        double width;

        public Rectangle(double v1, double v2)
        {
        }

        public Rectangle(double length, double x, double y)
        {
            this.length = length;
            this.width = width;
        }
        public override double CalculateArea()
        {
            return length * width;
        }
    }
    class Triangle : Shape
    {
        double h1;
        double width;

        public Triangle(double h1, double width)
        {
            this.h1 = h1;
            this.width = width;
        }

        public override double CalculateArea()
        {
            return 1 / 2 * width * h1;
        }
    }
}
