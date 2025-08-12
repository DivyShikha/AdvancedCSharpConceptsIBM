// See https://aka.ms/new-console-template for more information
using FileInputOutputOperations;

Console.WriteLine("Hello, World!");
string filepath1 = "furnitures.txt";
string filepath2 = "employee.txt";

//FileClassDemo(filepath1);
EmployeeStreamClass(filepath2);
static void FileClassDemo(string filePath1)
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
                Furnitures.AddFurniture(filePath1);
                break;
            case "2":
                Furnitures.ViewFurniture(filePath1);
                break;
            case "3":
                 Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
        }
    }
}

static void EmployeeStreamClass(string filepath2)
{

    Employee obj1 = new Employee();
    


    obj1.AddEmployee(new Employee("Akash", 101, "Sales"), filepath2);
    obj1.AddEmployee(new Employee("Divy", 102, "Consulting"), filepath2);
    obj1.AddEmployee(new Employee("Shivanshi", 102, "Consulting"), filepath2);
    obj1.ReadEmployees(filepath2);



}