    using Microsoft.EntityFrameworkCore;
    using DemoMVC.Models;
    namespace DemoMVC.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext > options) : base(options)
        {}
        
        public DbSet<Person> Person {get; set;}
        public DbSet<DemoMVC.Models.Faculty> Faculty { get; set; } = default!;

        public DbSet<Student> Student {get; set;}
       
        
        
       
        

        }
}

// trần thị mai anh 202105009