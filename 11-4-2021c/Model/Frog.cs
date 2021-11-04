using System;
using System.Collections.Generic;
using System.Text;
using _11_4_2021c.Abstract;

namespace _11_4_2021c.Model
{
    class Frog : Amphibians, IRun, ISwim
    {
         
        public int SwimSpeed { get; set; }
        public int RunSpeed { get; set; }

        

        void ISwim.Swim()
        {
            throw new NotImplementedException();
        }
        public override void Eat()
        {
            Console.WriteLine("Amphibians Eat");

        }

        public override void Live()
        {
            Console.WriteLine("Amphibians Live");
        }

        public override void Sleep()
        {
            Console.WriteLine("Amphibians Sleep");
        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
