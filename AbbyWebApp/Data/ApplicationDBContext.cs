using System;
using AbbyWebApp.Model;
using Microsoft.EntityFrameworkCore;

namespace AbbyWebApp.Data;

public class ApplicationDBContext : DbContext
{
    // this is a data layer that will connect us with our application
    //DbContext is used to access and manage the database

    // we will create db set for all the tables of our database

    // CONSTRUCTOR SHORTCUT IS CTOR and then tab
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options) : base(options)
    {
        
    }
    public DbSet<Categroy> Category {get; set;} // this is the name of the table







}
