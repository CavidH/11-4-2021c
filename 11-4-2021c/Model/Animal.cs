using System;
using System.Collections.Generic;
using System.Text;

namespace _11_4_2021c.Model
{
     abstract class Animal
    {
        public string Name { get; set; }
        

        public abstract void Live();
        public abstract void Sleep();
        public abstract void Eat();


    }
}
