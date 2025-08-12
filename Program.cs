// See https://aka.ms/new-console-template for more information
using FileInputOutputOperations;

Console.WriteLine("Hello, World!");
string filepath = "furnitures.txt";

FileClassDemo(filepath);
static object FileClassDemo(string filePath)
{
    while (true)
    {
        Console.WriteLine("\n--- Furniture App System ---");
        Console.WriteLine("1. Add New Furniture");
        Console.WriteLine("2. View All Furniture");
        Console.WriteLine("3. Exit");
        Console.Write("Choose an option (1-3): ");

        string? choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                Furnitures.AddFurniture(filePath);
                break;
            case "2":
                Furnitures.ViewFurniture(filePath);
                break;
            case "3":
                return Environment.Exit;
            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
        }
    }
}
