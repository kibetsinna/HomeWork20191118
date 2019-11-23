using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork20191118
{
    sealed class PetWolf : Wolf
    {
          public PetWolf(string name,string favoriteDogFood, string nameOfPack):base(name,favoriteDogFood,nameOfPack)
        {
           
        }
        public override void Bark()
        {
            Console.WriteLine("TYAF-U-U");
        }
    }
}
