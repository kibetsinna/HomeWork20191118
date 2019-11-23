using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork20191118
{
    class Dog:Animal
    {
        protected string _favoriteDogFood;
        public Dog(string name,string favoriteDogFood):base(name)
        {
            _favoriteDogFood = favoriteDogFood;
        }
        public virtual void Bark()
        {
            Console.WriteLine("GAV");
        }
        public override void MakeSound()
        {
            Bark();
        }
        public override string ToString()
        {
            return base.ToString() + " The faivorite food is " + _favoriteDogFood+".";
        }
    }
}
