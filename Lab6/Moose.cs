using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Moose : Animal
    {

        public string Horns = "big";

        public Moose(string legs, string namn, string eats, string habitat, int age) : base(legs, namn, eats, habitat, age)
        {
        }

        public void Fight()
        {
            Console.WriteLine("is in a battle");
        }
        public void MakeSound()
        {
            Console.WriteLine("MOOOOUUU");

        }
    }
}
