using System;
using FinalAssignment;
using Microsoft.EntityFrameworkCore;

namespace SchoolDatabase
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                //Creates a database
                context.Database.EnsureCreated();

                //Adds student to the database
                var student = new Student { Name = "Nick Sinclair" };
                context.Students.Add(student);
                context.SaveChanges();
            }
        }
    }
}

