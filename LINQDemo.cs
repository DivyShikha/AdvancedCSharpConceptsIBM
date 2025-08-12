using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInputOutputOperations
{
    internal class LINQDemo
    {
        int[]numbers = [20, 40, 500, 678, 45, 789, 100, 100002, 34];

        List<Employee> employees = new List<Employee> 
        { 
            new Employee("Divy", 101, "Physics"),
            new Employee("Ishika", 102, "Chemistry"),
            new Employee("Sudipto", 103, "Finance"),
            new Employee("Sanya", 104, "Finance"),
            new Employee("Jetlin", 105, "Physics"),
            new Employee("Karma", 106, "Physics"),
            new Employee("Deep", 107, "Chemistry"),
            new Employee("Sanjay", 108, "Physics"),
            new Employee("Udit", 109, "Chemistry")
        };
        ArrayList arraylist = new ArrayList
        {
            101, 102, 103, 104, 105, 106, 107, 108, "Divy", "Jetlin", "ishika", "Karma"
        };

        //LINQ Queries

        public void TakeLINQ()
        {
            Console.WriteLine("\nImplemeting Take in LINQ");
            var takeValues = numbers.Take(3);
            foreach (var val in takeValues)
            {
                Console.Write(val+" ");
            }
            Console.WriteLine("\nImplemeting TakeWhile in LINQ");
            var takeWhileValues = arraylist.OfType<int>();
            foreach(var val in takeWhileValues)
            {
                Console.Write($"{val}" + " ");
            }
        }
        public void OrderByLINQ()
        {
            Console.WriteLine("Implementing Order By and ThenBy");
            var orderedByValues = employees.OrderBy(x => x.Department).ThenByDescending(t => t.Id);
            foreach(var val in orderedByValues)
            {
                Console.Write(val+" ");
            }
        }
        public void GroupByLINQ()
        {
            Console.WriteLine("\nImplementing GroupBy");
            var GroupedByValues = employees.GroupBy(x => x.Department);
            foreach(var val in GroupedByValues)
            {
                Console.WriteLine($"\nDepartment: {val.Key}");
                foreach(var emp in val)
                {
                    Console.Write(emp.Name + " ");
                }
            }
        }
        public void WhereLINQ()
        {
            Console.WriteLine("\nImplementing Where Clause...");
            var result = from emp in employees
                         where emp.Id > 102
                         select emp;
            foreach (var emp in result)
            {
                Console.Write(emp.Id + ": "+ emp.Name);
            }
        }
        public void LINQOTypeArrayList()
        {
            Console.WriteLine("\nImplementing Type ArrayList...");
            var intValues = arraylist.OfType<int>();
            var stringValues = arraylist.OfType<string>();
            Console.WriteLine("int values...");
            foreach(var val in intValues)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine("string values...");
            foreach(var val in stringValues)
            {
                Console.Write(val + " ");
            }

        }
        public void BasicLINQQUery()
        {
            Console.WriteLine("Basic LINQ query...");
            var result = from no in numbers select no;
            foreach(var val in result)
            {
                Console.Write(val + " ");
            }
        }
        public void UsingQuerySyntaxOrderByLINQ()
        {
            Console.WriteLine("\nUsinf Query Syntax of Order By clause in LINQ...");
            var result = from emp in employees
                         orderby emp.Name descending
                         select emp;
            foreach (var emp in result)
            {
                Console.WriteLine(emp.Id + ": "+ emp.Name);
            }
        }

    }
}
