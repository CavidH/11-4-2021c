using System;
using _11_4_2021c.Abstract;

namespace _11_4_2021c.Model
{
    public class Eagle : Bird, IFly
    {
        public int FlySpeed { get; set; }

        public Eagle(string name, int flySpeed) : base(name)
        {
            FlySpeed = flySpeed;
        }


        public void Fly()
        {
            Console.WriteLine("fly as eagle");
        }
        public override void Eat()
        {
            Console.WriteLine("eat as eagle");
        }

        public override void Live()
        {
            Console.WriteLine("live as eagle");
        }

        public override void Sleep()
        {
            Console.WriteLine("sleep as eagle");
        }

         
    }
}