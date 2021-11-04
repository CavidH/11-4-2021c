using System;
using _11_4_2021c.Abstract;

namespace _11_4_2021c.Model
{
    public class Shark:Fish,ISwim
    {
        public Shark(string name, int swimSpeed) : base(name)
        {
            SwimSpeed = swimSpeed;
        }

        public int SwimSpeed { get; set; }
        public void Swim()
        {
            Console.WriteLine(" swim as Shark ");
        }
        
        public override void Eat()
        {
            Console.WriteLine("Eat as shark");
        }

        public override void Live()
        {
            Console.WriteLine("Eat as Shark");
        }

        public override void Sleep()
        {
            Console.WriteLine("Eat as Shark");
        }

         
    }
}