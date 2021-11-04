using System;
using System.Collections.Generic;
using System.Text;
using _11_4_2021c.Abstract;

namespace _11_4_2021c.Model
{
    class Monkey :Mammals,IRun
    {
        public int RunSpeed { get ; set; }

        public override void Eat()
        {
            Console.WriteLine("eat as Monkey ");
        }

        public override void Live()
        {
            Console.WriteLine("live as Monkey ");
        }

        public void Run()
        {
            Console.WriteLine(" Monkey is run ");

        }

        public override void Sleep()
        {
            Console.WriteLine("sleep as Monkey ");
        }
    }
}
