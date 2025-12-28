using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    interface IMovable
    {
        void Move();
    }

    interface ISound
    {
        void MakeSound();
    }
    class Robot : IMovable, ISound
    {
        public void Move()
        {
            Console.WriteLine("Robot is moving forward.");
        }

        public void MakeSound()
        {
            Console.WriteLine("Robot says: Beep");
        }
    }

}
