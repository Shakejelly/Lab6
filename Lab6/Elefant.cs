using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Elefant : Animal
    {

        public string Nose = "snabel";

        public Elefant(string legs, string namn, string eats, string habitat, int age) : base(legs, namn, eats, habitat, age)
        {
        }

        public void Size()
        {
            Console.WriteLine("is really huge");
        }
        public void MakeSound()
        {
            Console.WriteLine("TUUUUUUT");

        }
    }

}
