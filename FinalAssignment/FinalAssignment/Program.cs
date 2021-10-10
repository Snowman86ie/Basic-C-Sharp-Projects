using System;
using System.Data.Entity;

namespace FinalAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                var name = "Liam";
                var email = "liam@gmail.com";

                var student = new Student { Name = name, Email = email };
                db.Students.Add(student);
                db.SaveChanges();


            }

            Console.ReadLine();
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        
    }

    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
