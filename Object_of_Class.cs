using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Object_of_Class
    {
        static void Main(string[] args)
        {
           
            Product p1 = new Product
            {
                //ProductId = 101,
                ProductName = "Alto",
                Price = 1099561,
                UnitOfMeasurement = "pieces",
                Qty = 10
            };

            Product p2 = new Product
            {
                //ProductId = 102,
                ProductName = "Suzuki",
                Price = 247861,
                UnitOfMeasurement = "pieces",
                Qty = 50
            };

            Product p3 = new Product
            {
                //ProductId = 103,
                ProductName = "Wagner",
                Price = 157615,
                UnitOfMeasurement = "pieces",
                Qty = 75
            };

            Product p4 = new Product
            {
                // ProductId = 104,
                ProductName = "Boolero",
                Price = 193347,
                UnitOfMeasurement = "pieces",
                Qty = 30
            };

            Product p5 = new Product
            {
                // ProductId = 105,
                ProductName = "Neo",
                Price = 299198,
                UnitOfMeasurement = "pieces",
                Qty = 60
            };
            Product p6 = new Product();
            p6.ProductName = " Vitara";
            p6.Price = 789613;
            p6.UnitOfMeasurement = "pieces";
            p6.Qty = 80;
                
         
            Product[] prodArr = new Product[5];

            prodArr[0] = p1;
            prodArr[1] = p2;
            prodArr[2] = p3;
            prodArr[3] = p4;
            prodArr[4] = p5;

            Console.WriteLine("-----Product Data:------");
            foreach (Product product in prodArr)
            {
                Console.WriteLine($"Product Name: {p1.ProductName}");
                Console.WriteLine($"Product Name: {p2.ProductName}");
                Console.WriteLine($"Product Name: {p3.ProductName}"); 
                Console.WriteLine($"Product Name: {p4.ProductName}");
                Console.WriteLine($"Product Name: {p5.ProductName}");


                Console.WriteLine($"Product Name: {p6.ProductName}");
                Console.WriteLine();
                Console.ReadLine(); 
            }
        }

    }
 }
