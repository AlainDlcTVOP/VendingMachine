using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
     class Cheese : Product
    {
       
        public Cheese(string name, int price ,string description, string usi) : base(name, price, description,usi)
        {
           
        }

        public override void Examine(Product p)
        {
            //, to show the product’s price and info
            
              
            Console.WriteLine($"{p.Description}");
        }
        public override void Use(Product p)
        {
            /*to put the product to use once it has been purchased (output a string 
            message how to use the product*/
            Console.WriteLine($"{p.Id}Room temperature with charcuterie products");
        }
    }

   
}
