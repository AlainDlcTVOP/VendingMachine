using OpenXmlPowerTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public abstract class Product 
    {
        public Product()
        {
           
        }

        public Product(string name, int price, string description,string usi)
        {
            Name = name;
            Price = price;
            _index++;
            Id = _index;
            Description = description;
            Usi = usi;
            _newX = x;

        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Usi { get; }
        public int Price { get; set; }
        public int Id { get; set; }
        public int[] x { get; set; }

        
        private static int _index = 0;
        private static int[] _newX = new int[10] ;
        public abstract void Use(Product p);
        public abstract void Examine(Product p);






    }

}
