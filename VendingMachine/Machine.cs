using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
   
    public class Machine : IVending
    {

        List<Product> products = new List<Product>();

        public  int[] kr = new int[] { 1000, 500, 100, 50, 20, 10, 5,  1 };


        public  int kronorpool { get; set; }
       
        int peng = 0;

        public Machine()
        {

            Start();
            CreateListOfProducts();
              
        }
        public void Start()
        {
            Console.WriteLine("Feel free to enter your choice ");
        }

        private void CreateListOfProducts()
        {
            Cheese cheese = new Cheese("Blue cheese", 29, "Fits well with wine and cheese platter", "Room temperature with charcuterie products");
            products.Add(cheese);
            cheese = new Cheese("Cheddar", 63, "Hard or melted ", "For the best burgers taste");
            products.Add(cheese);
            cheese = new Cheese("Brie", 30, "French delicate", "cheese platter");
            products.Add(cheese);

            Meet meet = new Meet("Fillet of beef", 400, "Juicy and tender", "For Grill ");
            products.Add(meet);
            meet = new Meet("Sirloin", 160, "Protein rich", "Family dinners");
            products.Add(meet);
            meet = new Meet("Ground beef", 80, "Protein rich and low in fat", "Perfect for pasta");
            products.Add(meet);

            Drink drink = new Drink("Rom", 276, "Len oh good taste", "Suitable for mixing with cocacola");
            products.Add(drink);
            drink = new Drink("Vodka", 350, "Strong 40% alcohol", "Best suited for parties");
            products.Add(drink);
            drink = new Drink("Tequila", 320, "Original from mexico", "Lemon and salt for the best taste experiences");
            products.Add(drink);


        }



        public void EndTransaction()
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

        }

        public void EndTransactionTest(Product product)
        {
            
            
        }

        public void InsertMoney(bool sert, string val )
        {
            Console.WriteLine("Valid input 1kr, 5kr, 10kr, 20kr, 50kr, 100kr, 500kr and 1000kr");

            while (true)
            {
                bool test = true;
                string inputcoin;
                Console.Write("Insert money: ");
                if (sert)
                     inputcoin = Console.ReadLine();
                else
                     inputcoin = val;
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

                    if (product.Price <= kronorpool)
                    {
                        ExecutePurchase(product);
                        Console.WriteLine($"now is {kronorpool} kr");
                        Console.WriteLine($"Use : {product.Usi}");
                        
                    }
                    
                }
                else if (kronorpool < product.Price)
                {
                    Console.WriteLine($"To low to purchase");
                }

            }

        }

        public void ExecutePurchase(Product p)
        {
          
            kronorpool -= p.Price;
        }
        

       

        public void ShowAll()
        {


            foreach(Product product in products)
            {
                Console.WriteLine($"id:{product.Id} Product {product.Name} Cost = {product.Price} Description: {product.Description}");
            }

           

        }
        
    }
}
