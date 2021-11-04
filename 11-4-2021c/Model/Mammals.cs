using System;
using System.Collections.Generic;
using System.Text;
using _11_4_2021c.Abstract;

namespace _11_4_2021c.Model
{
    class Mammals : Animal 
    {
        public Mammals(string name) : base(name)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("eat as Mammals ");
        }

        public override void Live()
        {
            Console.WriteLine("live as Mammals ");
        }

        public override void Sleep()
        {
            Console.WriteLine("sleep as Mammals ");
        }
    }
}
