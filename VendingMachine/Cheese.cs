using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
     class Cheese : Product
    {
        public Cheese(string name, int price) : base(name, price)
        {
        }

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
