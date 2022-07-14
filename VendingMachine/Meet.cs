using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
     class Meet : Product
    {
        public Meet(string name, int price, string description, string usi) : base(name, price ,description ,usi)
        {
        }

        public override void Examine(Product p)
        {
            //, to show the product’s price and info


            Console.WriteLine($"{p.Description}");
        }
        public override void Use(Product p)
        {
            Console.WriteLine($"{p.Usi}");
        }
    }
}
