using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork20191118
{
    class Program
    {
        static void AnimalSing(Animal[] animals)
        {
            foreach (Animal item in animals)
            {
               Console.WriteLine(item);
                item.MakeSound();
            }
        }
        static Horse[] GetRacingHorce(Horse[] horses)
        {
            if (horses == null)
                return null;
            int horceRacingNumber = 0;
            foreach(Horse h in horses)
            {
               if (h._racingHorse)
                horceRacingNumber++;

            }
            Horse [] RacingH=new Horse[horceRacingNumber];
            int i = 0;
            foreach (Horse h in horses)
            {
                if (h._racingHorse)
                {
                    RacingH[i] = h;
                    i++;
                }
            }
            if (horceRacingNumber > 0)
            {

                return RacingH;
            }
            else
                return null;

        }
        static void Main(string[] args)
        {
            Wolf akela = new Wolf("Akela", "Cow", "Free Pack");
            Poodle toshka = new Poodle("Toshka", "Apple", 15);
            PetWolf maugli = new PetWolf("Maugli", "Milk", "Free Pack");
            Horse black = new Horse("Black", true);
            Horse white = new Horse("White", true);
            Horse small = new Horse("Small", false);
            Animal[] animals = new Animal[6];
            animals[0] = akela;
            animals[1] = toshka; 
            animals[2] = maugli; 
            animals[3] = black; 
            animals[4] = white; 
            animals[5] = small;
            AnimalSing(animals);
            Horse[] h = new Horse[3];
            h[0] = black;
            h[1]= white;
            h[2] = small;
            Horse[] h1 = GetRacingHorce(h);
            Console.WriteLine("There is "+h1.Length+" racing Horses");
            foreach (Horse item in h1)
                Console.WriteLine(item);
            Console.ReadLine();


        }
    }
}
