using System;
using System.Collections.Generic;
using System.Text;
using _11_4_2021c.Abstract;

namespace _11_4_2021c.Model
{
    class Amphibians : Animal 
    {
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
    }
}
