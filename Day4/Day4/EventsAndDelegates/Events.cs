using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.EventsAndDelegates
{
    
    public class Product
    {
        public string productId { get; set; }
        public double price { get; set; }
        public bool idDefective { get; set; }
    }

    public class Inventory
    {
        Dictionary<string, int> ProductList = new Dictionary<string, int>();
        public Inventory()
        {
                Console.WriteLine("Items in the dictionary are:");
                ProductList.Add("Product1", 10);
                ProductList.Add("Product2", 20);
                ProductList.Add("Product3", 5);
                ProductList.Add("Product4", 1);
                ProductList.Add("Product5", 23);
                foreach (KeyValuePair<string, int> prod in ProductList)
                {
                    Console.WriteLine("{0} and {1}", prod.Key, prod.Value);
                }
                int totalValue = ProductList.Sum(x => x.Value);
                Console.WriteLine("\nThe total value of the inventory is : " + totalValue);


            Console.WriteLine("Removing a product");
              
            ProductList.Remove("Product2");
                int totalValuenew = ProductList.Sum(x => x.Value);

                Console.WriteLine("\nThe total value of the inventory is : " + totalValuenew);

            
            Console.ReadKey();
        }




    }
    class Events
    {
        
    }
}
