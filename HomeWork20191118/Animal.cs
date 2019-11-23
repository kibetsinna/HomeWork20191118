using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork20191118
{
    public abstract class Animal
    {
        protected string _name;
        public Animal(string name)
        {
            _name = name;
        }
        public abstract void MakeSound();
        public override string ToString()
        {
          
            return "Name  is "+_name+".";
        }
    }
}
