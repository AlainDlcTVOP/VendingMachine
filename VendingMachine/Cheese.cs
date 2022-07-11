using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
     class Cheese : Machine
    {
        public override void Examine()
        {
            Console.WriteLine("Is");
        }
        public override void Use()
        {
            Console.WriteLine("Is");
        }
    }

   
}
