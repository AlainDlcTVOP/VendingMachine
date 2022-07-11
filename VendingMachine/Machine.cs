using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
   
    internal class Machine : IVending
    {
        List<Product> products = new List<Product>();

        public Machine()
        {
           CreateListOfProducts();
            
        }

        private void CreateListOfProducts()
        {
            Cheese cheese = new Cheese();
            cheese.Name = "blue cheese";
            cheese.Price = 89;
            products.Add(cheese);

            Meet meet = new Meet();
            meet.Name = "oxfile";
            meet.Price = 201;
            products.Add(meet);

            Drink drink = new Drink();
            drink.Name = "Vino tinto";
            drink.Price = 50;
            products.Add(drink);

        }

        

        public void EndTransaction()
        {
            throw new NotImplementedException();
        }

        public int InsertMoney(int money)
        {
            throw new NotImplementedException();
        }

        public Product Purchase(int input)
        {
            throw new NotImplementedException();
        }

        public void ShowAll()
        {


            foreach(Product product in products)
            {
                Console.WriteLine( product.Price);
            }
                

            
        }
    }
}
