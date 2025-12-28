using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    public class Vehicals
    {
        public void Vdisplay()
        {
            Console.WriteLine("Vehical class");
        }
    }
   public class car:Vehicals
    {
        public void Cdisplay()
        {
            Console.WriteLine("Car class");
        }
    }
    public class ElectricCar : car
    {
        public void Edisplay()
        {
            Console.WriteLine("Electriccar derived vehical class");
        }
    }
}
