using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class SuperSloth : Sloth
    {

        public string fly = "flying";
        public SuperSloth(string legs, string namn, string eats, string habitat, int age) : base(legs, namn, eats, habitat, age)
        {
            
        }
        public void SuperFly()
        {
            Console.WriteLine("Is flying over you.");
        }
    }

}
