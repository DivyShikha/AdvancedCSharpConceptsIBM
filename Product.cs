using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInputOutputOperations
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }

        public Product() { }
        public Product(int id, string name, double price)
        {
            ProductId = id; 
            ProductName = name;
            ProductPrice = price;
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
    }
}
