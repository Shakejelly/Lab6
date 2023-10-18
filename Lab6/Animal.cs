using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Animal

    {
        public string Legs { get; set; }
        public string Namn { get; set; }

        public string Eats { get; set; }
        public int Age { get; set; }
        public string Habitat { get; set; }

        public Animal(string legs, string namn, string eats, string habitat, int age)
        {
            Legs = legs;
            Namn = namn;
            Eats = eats;
            Age = age;
            Habitat = habitat;
              
        }


        public void AverageAge()
        {
            Age = Age * 100;

        }
            
        public void IsAlien()
        {
            if (Habitat != null)
            {
                Console.WriteLine("is an Alien");
            }
            else { Console.WriteLine("is not an Alien"); }

        }
        public void IsOld()
        {
            if (Age > 50)
            {
                Console.WriteLine("Is over its due date.");
            }
            else
            {
             Console.WriteLine("is a young one.");
            }
               
            
        }


    }
}
