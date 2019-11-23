using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork20191118
{
    class Horse:Animal
    {
        public bool _racingHorse;
        public Horse(string name,bool racingHorse):base(name)
        {
            _racingHorse = racingHorse;
        }
        public virtual void Neigh()
        {
            Console.WriteLine("I-Go-Go");
        }
        public override void MakeSound()
        {
            Neigh();
        }
        public override string ToString()
        {
            string isRacing=_racingHorse?" racing.":" not racing.";
            return base.ToString()+" Horse is "+isRacing;
        }
    }
}
