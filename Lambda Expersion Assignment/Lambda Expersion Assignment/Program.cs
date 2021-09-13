using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expersion_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employee = new List<Employee>();
            
            employee.Add(new Employee() { Id=0, FirstName = "Paul", LastName = "Smith" });
            employee.Add(new Employee() { Id=1, FirstName = "Joe", LastName = "Peters" });
            employee.Add(new Employee() { Id=2, FirstName = "Alan", LastName = "Jones" });
            employee.Add(new Employee() { Id=3, FirstName = "John", LastName = "Rogers" });
            employee.Add(new Employee() { Id=4, FirstName = "Chloe", LastName = "Bennett" });
            employee.Add(new Employee() { Id = 5, FirstName = "Tara", LastName = "Rogers" });
            employee.Add(new Employee() { Id = 6, FirstName = "Joe", LastName = "Bennett" });
            employee.Add(new Employee() { Id = 7, FirstName = "Joe", LastName = "Parker" });
            employee.Add(new Employee() { Id = 8, FirstName = "Liam", LastName = "Curtin" });
            employee.Add(new Employee() { Id = 9, FirstName = "Thomas", LastName = "Murphy" });

            foreach (Employee num in employee)
            {
                if (num.FirstName == "Joe")
                {
                    Console.WriteLine(num.FirstName + num.LastName);
                }
            }
            Console.WriteLine();

            List<Employee> search = employee.Where(x => x.FirstName == "Joe").ToList();

            foreach(Employee emp in search)
            {
                Console.WriteLine(emp.FirstName + " " + emp.LastName);
            }

            Console.WriteLine();
            search = employee.Where(x => x.Id > 5).ToList();

            foreach(Employee employee2 in search)
            {
                Console.WriteLine(employee2.FirstName + " " + employee2.LastName);
            }

            Console.ReadLine();

            

            
        }

        
    }
    public class Employee
            {
                public int Id { get; set; }
                public string FirstName { get; set; }
                public string LastName { get; set; }
                
            }
}
