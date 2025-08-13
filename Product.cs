using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FileInputOutputOperations
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public DateTime ManufactureDate { get; set; }

        public Product() { }
        public Product(int id, string name, double price, DateTime manfDate)
        {
            ProductId = id;
            ProductName = name;
            ProductPrice = price;
            ManufactureDate = manfDate;
        }
        public void DisplayProductDetails()
        {
            Console.WriteLine("Displaying product Details....");
            Console.WriteLine($"Product Name: {ProductName},  ID : {ProductId}, Product Price: {ProductPrice}");
        }
        public void ReadProductEntry(string filepath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filepath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            catch (IOException ioEx)
            {
                Console.WriteLine($"{ioEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }
        public void WriteProductEntry(Product product, string filepath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filepath, append: true))
                {
                    writer.WriteLine($"ID: {product.ProductId}, Name: {product.ProductName}, Price: {product.ProductPrice}");
                }
            }
            catch (IOException ioEx)
            {
                Console.WriteLine($"Some error occured: {ioEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Some error occured: {ex.Message}");
            }
        }
        public void FindFirstVal(List<Product> prod)
        {
            Console.WriteLine("\nImplementing First LINQ");
            var firstVal = prod.FirstOrDefault(p => p.ProductName == "Chair");
            Console.WriteLine(firstVal.ProductId);
        }
        public void FindSingleVal(List<Product> prod)
        {
            Console.WriteLine("\nImplementing Single LINQ");
            var singleVal = prod.SingleOrDefault(p => p.ProductId == 101);
            Console.WriteLine(singleVal.ProductName);
        }
        //Grpup by
        public void GroupByVal(List<Product> prod)
        {
            Console.WriteLine("\nImplementing Group By LINQ");

            var groupVal = prod.GroupBy(p => p.ProductName );
            foreach (var group in groupVal)
            {
                Console.WriteLine(group.Key);
                foreach (Product product in group)
                {
                    Console.WriteLine(product.ProductId);
                    Console.WriteLine(product.ProductName);
                    Console.WriteLine(product.ManufactureDate);
                }
            }
        }
        //OrderBy
        public void OrderByVal(List<Product> prod)
        {
            Console.WriteLine("\nImplementing Order By LINQ\n");
            var orderVal = prod.OrderBy(p => p.ProductPrice);
            foreach (var val in orderVal)
            {
                Console.Write(val.ProductPrice + " ");
            }
        }
        //Take and TakeWhile
        public void TakeAndTakeWhile(List<Product> prod)
        {
            Console.WriteLine("Implementing Take and TakeWhile...");
            var takeValues = prod.Take(4);
            foreach(var val in takeValues)
            {
                Console.Write(val.ProductId + " ");
            }
            var takeWhileValues = prod.TakeWhile(p => p.ProductName == "Chair");
            Console.WriteLine();
            foreach(var val in takeWhileValues)
            {
                Console.Write(val.ProductId+" ");
            }
        }
    }
}
