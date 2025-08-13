using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FileInputOutputOperations
{
    internal class Employee
    {
        public string? Name { get; set; }
        public int Id { get; set; }
        public string? Department { get; set; }
        public Employee() { }
        public Employee(string name, int id, string department)
        {
            Name = name;
            Id = id;
            Department = department;
        }
        public void SerializeDeserializeEmployee(Employee emp)
        {
            string jsonString = JsonSerializer.Serialize(emp);
            Console.WriteLine($"Serialized object: {jsonString}");
            Employee emp2 = JsonSerializer.Deserialize<Employee>(jsonString);
            Console.WriteLine($"Deserialized object - Name:  {emp2.Name}, ID = {emp2.Id}, Department = {emp2.Department}");


        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Employee name: {Name}, Id: {Id}, Department: {Department}");
        }

        public void AddEmployee(Employee employee, string filepath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filepath, append: true))
                {
                    writer.WriteLine($"Name: {employee.Name}, Id: {employee.Id}, Department: {employee.Department}");
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
        public void ReadEmployees(string filepath)
        {
            Console.WriteLine($"Reading lines {filepath}...");
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
        }  
    
}
