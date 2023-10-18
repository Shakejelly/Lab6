using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Sloth : Animal
    {
        public string Claws = "sharp";

        public Sloth(string legs, string namn, string eats, string habitat, int age) : base(legs, namn, eats, habitat, age)
        {
        }

        public void Climb()
        {
            Console.WriteLine("is climbing on a tree");
        }
        public void MakeSound()
        {
           
            Console.WriteLine("ChOOkakKikIEKekA");

        }

    }
}
