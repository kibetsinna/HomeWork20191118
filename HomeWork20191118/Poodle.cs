using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork20191118
{
    class Poodle:Dog
    {
        protected int _numberOfPonyTails;
   
        public Poodle(string name,string favoriteDogFood, int numberOfPonyTails) :base(name,favoriteDogFood)
        {
            _numberOfPonyTails = numberOfPonyTails;
        }
        public override void Bark()
        {
            Console.WriteLine("TYAF-TYAFFF");
        }
        public override void MakeSound()
        {
            Bark();
        }
        public override string ToString()
        {
            return base.ToString() + " The number of the ponytails  is " + _numberOfPonyTails + ".";
        }
    }
}
