using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class MegaSloth : Sloth
    {

        public string run = "fast runner";
        public MegaSloth(string legs, string namn, string eats, string habitat, int age) : base(legs, namn, eats, habitat, age)
        {
            
        }

        public void SuperRun()
        {
            Console.WriteLine("is running past you");
        }
    }
}
