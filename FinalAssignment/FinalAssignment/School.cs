using System;
using System.Collections.Generic;
using System.Text;
using FinalAssignment;
using Microsoft.EntityFrameworkCore;

public class SchoolContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    //configures database connection
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //utilizes local SQL Express server for Schooldb
        optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;");
    }
}