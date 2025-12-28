using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    abstract class Appliance
    {
        abstract public void TurnOn();
        
    }
    class Fan : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine("Fan turn on");
        }
    }
    class Light : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine("Light turn on");
        }
    }
}
