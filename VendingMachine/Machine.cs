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

            Cheese cheese1 = new Cheese();
            cheese.Name = "blue cheese";
            cheese.Price = 89;
            products.Add(cheese1);

            Meet meet1 = new Meet();
            meet1.Name = "oxfile";
            meet1.Price = 201;
            products.Add(meet1);

            Drink drink1 = new Drink();
            drink1.Name = "Vino tinto";
            drink1.Price = 50;
            products.Add(drink1);

            Cheese cheese2 = new Cheese();
            cheese2.Name = "blue cheese";
            cheese2.Price = 89;
            products.Add(cheese2);

            Meet meet2 = new Meet();
            meet2.Name = "oxfile";
            meet2.Price = 201;
            products.Add(meet2);

            Drink drink2 = new Drink();
            drink2.Name = "Vino tinto";
            drink2.Price = 50;
            products.Add(drink2);

        }

        

        public void EndTransaction()
        {
            throw new NotImplementedException();
        }

        public int InsertMoney(int money)
        {
            int[] denominations = { 1, 5, 10, 20, 50, 100, 500, 1000 };

            return money;
           
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
