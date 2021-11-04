using System;
using System.Collections.Generic;
using System.Text;

namespace _11_4_2021c.Model
{
    public abstract class Animal
    {
        public string Name { get; set; }

        protected Animal(string name)
        {
            Name = name;
        }

        public abstract void Live();
        public abstract void Sleep();
        public abstract void Eat();


    }
}
