using System;

namespace Lab07Kyle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Take a look at my new Inventory!");

            Product product = new Product();

            Inventory<Product> InventoryList = new Inventory<Product>();

            InventoryList.Add(product);
            InventoryList.Add(new Product { ProductMetalType = Metal.bronze });
            InventoryList.Add(new Product { ProductMetalType = Metal.adamantine });
            InventoryList.Add(new Product { ProductMetalType = Metal.silver });
            InventoryList.Add(new Product { ProductMetalType = Metal.steel });
            InventoryList.Add(new Product { ProductMetalType = Metal.cold_iron });
            InventoryList.Add(new Product { ProductBladeLength = Blade.inches_twenty });
            InventoryList.Add(new Product { ProductBladeLength = Blade.inches_twentfour });
            InventoryList.Add(new Product { ProductBladeLength = Blade.inches_thirty });
            InventoryList.Add(new Product { ProductBladeLength = Blade.inches_forty });

            foreach (Product p in InventoryList)
            {
                Console.WriteLine(p.ProductMetalType);
                Console.WriteLine(p.ProductBladeLength);
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}


/* 
 Inventory<product> inventoryList = new Inventory<product>();
 Product sword = new Product(


inventoryList.Add();


foreach(product p in inventroyList)
{
    Console.WriteLine(p.Product);
}
     */