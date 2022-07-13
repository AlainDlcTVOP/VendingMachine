using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public abstract class Product 
    {


        public Product(string name, int price)
        {
            Name = name;
            Price = price;
            _index++;
            Id = _index;
        }

        public string Name { get; set; }
        public int Price { get; set; }
        public int Id { get; set; }

        private static int _index = 0;
        public abstract void Use();
        public abstract void Examine();






    }

}
