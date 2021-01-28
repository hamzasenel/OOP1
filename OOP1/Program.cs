using System;

namespace OOP1
{
    class Program
    {
        static void Main(String[] args)
        {
            String[] dizi = new String[]{ "asd","asd","fad"};
            Console.WriteLine("Hello World!");
            Product product1 = new Product { Id = 12,CategoryId=2, ProductName = "huhs",UnitPrice=3,UnitInStock=500 };
            ProductManager productManager = new ProductManager(); Console.WriteLine("-----");
            productManager.Add(product1); Console.WriteLine("-----");
            
            Console.WriteLine();
            foreach (string item in dizi)
            {
                Console.WriteLine(item);
            }
            int[] sayilar1 = new int[] {1,2,3 };
            int[] sayilar2 = new int[] { 10,20,30};
            sayilar1 = sayilar2;
            //sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);
        }
    }
}
