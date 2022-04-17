using Microsoft.EntityFrameworkCore;
namespace assignment_crudelicious_02.Models
{ 
    public class MyContext : DbContext 
    { 
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<Pet> Pets { get; set; }
    }
}