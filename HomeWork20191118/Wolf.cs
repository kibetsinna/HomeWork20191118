using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork20191118
{
    class Wolf:Dog
    {
        protected string _nameOfPack;
        public Wolf(string name,string favoriteDogFood, string nameOfPack):base(name,favoriteDogFood)
        {
            _nameOfPack = nameOfPack;
        }
 
        public override void MakeSound()
        {
            Bark();
        }
        public override string ToString()
        {
            return base.ToString() + " The name of the pack  is " + _nameOfPack+".";
        }
    }
}
