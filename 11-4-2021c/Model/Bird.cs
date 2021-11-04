using System;
using System.Collections.Generic;
using System.Text;
using _11_4_2021c.Abstract;

namespace _11_4_2021c.Model
{
    class Bird : Animal 
    {
        public override void Eat()
        {
            Console.WriteLine("eat as bird");
        }

        public override void Live()
        {
            Console.WriteLine("live as bird");
        }

        public override void Sleep()
        {
            Console.WriteLine("sleep as bird");
        }
    }
}
