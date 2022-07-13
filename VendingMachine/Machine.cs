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

        public static int[] kr = new int[] { 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };


        public static int kronorpool { get; set; }
       
        int peng = 0;

        public Machine()
        {



            Start();
            InsertMoney();
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

        public void InsertMoney( )
        {
            //1kr, 5kr,10kr,20kr, 50kr, 100kr, 500kr and 1000kr.
            while (true)
            {
                bool test = true;
                Console.Write("Insert money: ");
                string inputcoin = Console.ReadLine();
                try
                {
                    test = int.TryParse(inputcoin, out peng);
                }
                catch
                {
                    Console.Write("Catch error ");
                }

                bool acceptable = false;
                for (int i = 0; i < kr.Length; i++)
                {
                    if (peng == kr[i]) acceptable = true;
                    if (acceptable) break;
                }

                if (test && acceptable) break; 
                else Console.WriteLine("Error");
            }
            kronorpool = kronorpool + peng;

           

        }
       
           
           


            public void Purchase()
        {
            int val = int.Parse(Console.ReadLine());
            


            foreach (Product product in products)
            {
                   
                    if (product.Id == val)
                {

                    if (  product.Price <= kronorpool)
                    {
                        kronorpool -= product.Price;
             
                        Console.WriteLine($"now is {kronorpool} kr");
                    }
                }else if(kronorpool < product.Price)
                {
                    Console.WriteLine($"To low to purchase");
                }
            }
        }

        public  void MoneyBack()
        {
            foreach (int val in kr)
            {
                int antal = kronorpool / val;
                kronorpool -= antal * val; 
                if (antal > 0)
                {
                    Console.WriteLine("You get back:");
                    Console.WriteLine($"{val} x {antal}kr");

                }
            }
        }//sepmoney

        public void ShowAll()
        {


            foreach(Product product in products)
            {
                Console.WriteLine($"id:{product.Id} Product {product.Name} Cost = {product.Price}");
            }

           

        }
        
    }
}
