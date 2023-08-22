//Program.cs
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_Expression_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main() method, create list of 10 employees, with two named joe.
            List<Employee> campus = new List<Employee>()
            {
                new Employee() {Id = 1, FirstName = "Joe", LastName = "Snow"},
                new Employee() {Id = 2, FirstName = "Joe", LastName = "Bill"},
                new Employee() {Id = 3, FirstName = "Nick", LastName = "Gates"},
                new Employee() {Id = 4, FirstName = "Bob", LastName = "Winters"},
                new Employee() {Id = 5, FirstName = "Oscar", LastName = "Fathem"},
                new Employee() {Id = 6, FirstName = "Marie", LastName = "Thomas"},
                new Employee() {Id = 7, FirstName = "Amanda", LastName = "Dune"},
                new Employee() {Id = 8, FirstName = "Josh", LastName = "Dune"},
                new Employee() {Id = 9, FirstName = "Mary", LastName = "Autumn"},
                new Employee() {Id = 10, FirstName = "Nina", LastName = "Clatch"},
            };
            //Using foreach loop, creat  new list of all employee with the first name joe
            List<Employee> joes = new List<Employee>();
            foreach (Employee employee in campus)
            {
                if (employee.FirstName =="Joe")
                {
                    joes.Add(employee);
                }
            }
            //Repeat the previous but now with a lambda expression
            List<Employee> joes2 = campus.Where(x => x.FirstName == "Joe").ToList();
            //Using lambda empression, make list of all employees with an Id number greater than 6
            List<Employee> bigId = campus.Where(x => x.Id > 5).ToList();
            Console.ReadLine();
        }
    }
}
