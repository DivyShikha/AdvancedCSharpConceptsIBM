using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FileInputOutputOperations
{
    internal class Furnitures
    {
        
        public Furnitures() { }

        public Furnitures(string name, int quantity)
        {
            
        }
        public static void AddFurniture(string filePath)
        {
            try
            {
                Console.WriteLine("Furniture name: ");
                string? Name = Console.ReadLine();

                Console.WriteLine("Quantity: ");
                int? Quantity = Convert.ToInt32(Console.ReadLine());

                string? input = $"{Name}, {Quantity}";
                File.AppendAllText(filePath, input + Environment.NewLine);
            }catch(IOException ex)
            {
                Console.WriteLine("An error occurred while writing to the file: " +
                   ex.Message);
            }catch(Exception ex){
                Console.WriteLine("An error occurred while writing to the file: " +
                   ex.Message);
            }
        }
        public static void ViewFurniture(string filepath)
        {
            try
            {
                if (!File.Exists(filepath))
                {
                    Console.WriteLine("No Furniture exist!");
                }
                string[] furnitures = File.ReadAllLines(filepath);

                foreach(var furniture in furnitures){
                    string[] parts = furniture.Split(',');
                    Console.WriteLine($"Furniture type: {parts[0]}, Quantity: {parts[1]}");
                }

            }catch(IOException ioEx)
            {
                Console.WriteLine($"Some error occured: {ioEx.Message}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Some error occured: {ex.Message}");

            }

        }
        

    }
}
