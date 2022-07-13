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

        public int AviableFound { get; set; }

        public Machine()
        {
            AviableFound = 15000;
            
           CreateListOfProducts();
            
        }
        public void Start()
        {
            Console.WriteLine("Feel free to enter your choice ");
        }

        private void CreateListOfProducts()
        {
            Cheese cheese = new Cheese("Blue cheese", 9);
            products.Add(cheese);
            cheese = new Cheese("Cheddar", 12);
            products.Add(cheese);
            cheese = new Cheese("Brie", 3);
            products.Add(cheese);

            Meet meet = new Meet("Fillet of beef", 40);
            products.Add(meet);
            meet = new Meet("Sirloin", 16);
            products.Add(meet);
            meet = new Meet("Ground beef", 8);
            products.Add(meet);

            Drink drink = new Drink("Rom", 20);
            products.Add(drink);
            drink = new Drink("Vodka", 40);
            products.Add(drink);
            drink = new Drink("Tequila", 20);
            products.Add(drink);


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

        public void Purchase()
        {
            Console.WriteLine($"Use id o purcase your product");
            int val = int.Parse(Console.ReadLine());
            foreach (Product product in products)
            {
                if (product.Id == val)
                {

                    if (product.Price <= AviableFound)
                    {
                        AviableFound -= product.Price;
             
                        Console.WriteLine($"now is {AviableFound} kr");
                    }
                }
            }
        }

        public void ShowAll()
        {


            foreach(Product product in products)
            {
                Console.WriteLine($"id:{product.Id} Product {product.Name} Cost = {product.Price}");
            }
                

            
        }
    }
}
